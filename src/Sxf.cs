using System.Collections;
using System.Reflection;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using sxfsharp.builders;
using sxfsharp.reads;

namespace sxfsharp;

public static class Sxf
{
    
    /* filters */
    private static Predicate<FieldInfo> attributeFilter = info =>  info.GetCustomAttribute<SxfField>() != null;
    private static Predicate<FieldInfo> allFilter = info => true; 
    private static Predicate<FieldInfo> publicFilter = info => info.IsPublic; 
    
    public static X Parse<X> (string input)
    {
        SxfBlock block = Sxf.Read(input);
        Type typeParameterType = typeof(X);
        return (X) ParseObject(block, typeParameterType);
    }

    private static object? ParseObject(SxfBlock? block, Type type)
    {
        if (block == null)
            return null;
        
        object? instance = Activator.CreateInstance(type);
        foreach (FieldInfo fieldInfo in type.GetFields())
        {
            
            string name = FieldName(fieldInfo);
            if (block.Variables.ContainsKey(name))
            {
                switch (Type.GetTypeCode(fieldInfo.FieldType))
                {
                    case TypeCode.DateTime:
                    {
                        fieldInfo.SetValue(instance, DateTime.Parse((string) block.Variables[name]));
                        break;
                    }
                    case TypeCode.Int64:
                    {
                        fieldInfo.SetValue(instance, System.Convert.ToInt64((string) block.Variables[name]));
                        break;
                    }
                    case TypeCode.SByte:
                    {
                        fieldInfo.SetValue(instance, System.Convert.ToSByte((string) block.Variables[name]));
                        break;
                    }
             
                    case TypeCode.Char:
                    {
                        string value = (string) block.Variables[name];
                        if (String.IsNullOrEmpty(value))
                            break;
                        
                        fieldInfo.SetValue(instance, value[0]);
                        break;
                    }
                    case TypeCode.Decimal:
                    {
                        fieldInfo.SetValue(instance, System.Convert.ToDecimal((string) block.Variables[name]));
                        break;
                    }
                    case TypeCode.Object:
                    {
                        Console.WriteLine(fieldInfo.Name);
                        if (fieldInfo.FieldType.IsArray) break;
                        // {
                        //     SxfStruct sxfStruct = (SxfStruct) block.Variables[name];
                        //     Array array = (Array) Activator.CreateInstance(fieldInfo.FieldType);
                        //     for (int i = 0; i < sxfStruct.Elements.Count; i++)
                        //     {
                        //         array.SetValue(sxfStruct.Elements[i], i);
                        //     }
                        //     fieldInfo.SetValue(instance, array);
                        //
                        //     break;
                        // }

                        if (fieldInfo.FieldType.IsGenericType &&
                            fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            break;
                        }
                        fieldInfo.SetValue(instance, ParseObject((SxfBlock) block.Variables[name], 
                            fieldInfo.FieldType));

                        // add support for lists and arrays-

                        break;
                    }
                    default:
                    {
                        fieldInfo.SetValue(instance, block.Variables[name]);
                        break;
                    }
                }
            }
        }

        return instance;
    }
    
    public static string Convert(Object instance, ConvertFieldSetting fieldSetting = ConvertFieldSetting.ATTRIBUTED)
    {
        SxfBlockBuilder builder = CreateBlockFromInstance(instance, fieldSetting);
        return builder.ToString();
    }

    private static SxfBlockBuilder CreateBlockFromInstance(Object instance, ConvertFieldSetting fieldSetting)
    {
        SxfBlockBuilder blockBuilder = SxfBlockBuilder.Create();
        Predicate<FieldInfo> filter;
        switch (fieldSetting)
        {
            case ConvertFieldSetting.ALL:
            {
                filter = allFilter;
                break;
            }
            case ConvertFieldSetting.ATTRIBUTED:
            {
                filter = attributeFilter;
                break;
            }
            case ConvertFieldSetting.ONLY_PUBLIC:
            {
                filter = publicFilter;
                break;
            }
            default:
            {
                filter = attributeFilter;
                break;
            }
        }

        foreach (FieldInfo fieldInfo in instance.GetType().GetFields())
        {
            if (filter.Invoke(fieldInfo))
            {

                Object value = fieldInfo.GetValue(instance);
                if (value == null)
                {
                    blockBuilder.Add(FieldName(fieldInfo), null);
                    continue;
                }
                
                switch (Type.GetTypeCode(fieldInfo.FieldType))
                {
                    case TypeCode.String:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value);
                        break;
                    }
                    case TypeCode.Int32:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value);
                        break;
                    }
                    case TypeCode.Int16:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value);
                        break;
                    }
                    case TypeCode.DateTime:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), ((DateTime)value).ToLongDateString());
                        break;
                    }
                    case TypeCode.Int64:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value.ToString());
                        break;
                    }
                    case TypeCode.SByte:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value.ToString());
                        break;
                    }
                    case TypeCode.Double:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value);
                        break;
                    }
                    case TypeCode.Char:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value.ToString());
                        break;
                    }
                    case TypeCode.Decimal:
                    {
                        blockBuilder.Add(FieldName(fieldInfo), value.ToString());
                        break;
                    }
                    case TypeCode.Object:
                    {
                        if (value is IList)
                        {
                            IList list = (IList) value;
                            SxfStructBuilder strutBuilder = SxfStructBuilder.Create();
                            foreach (object? o in list)
                            {
                                if (Type.GetTypeCode(o.GetType()) == TypeCode.Object)
                                {
                                    strutBuilder.Add(CreateBlockFromInstance(o, fieldSetting));
                                    continue;
                                }
                                strutBuilder.Add(o);
                            }

                            blockBuilder.Add(FieldName(fieldInfo), strutBuilder);
                            break;
                        }

                        if (value is Array)
                        {
                            Array array = (Array) value;
                            SxfStructBuilder strutBuilder = SxfStructBuilder.Create();
                            foreach (object? o in array)
                            {
                                if (Type.GetTypeCode(o.GetType()) == TypeCode.Object)
                                {
                                    strutBuilder.Add(CreateBlockFromInstance(o, fieldSetting));
                                    continue;
                                }
                                strutBuilder.Add(o);
                            }

                            blockBuilder.Add(FieldName(fieldInfo), strutBuilder);
                            break;
                        }
                        
                        blockBuilder.Add(FieldName(fieldInfo), CreateBlockFromInstance(value, fieldSetting));
                        break;
                    }
                }
            }
        }

        return blockBuilder;
    }


    private static string FieldName(FieldInfo field)
    {
        SxfField? sxfField = field.GetType().GetCustomAttribute<SxfField>();
        if (sxfField == null)
            return Commons.ClearName(field.Name);
        
        return sxfField.Alias;

    }
    /*public static X? Convert<X>(string rawSxf)
    {
        return null;
    }*/

    public static SxfBlock Read(string rawSxf)
    {
        return SxfReader.ToSxfBlock(rawSxf);
    }
}

public enum ConvertFieldSetting
{
    ONLY_PUBLIC, ALL, ATTRIBUTED
}

static class SxfReader
{

    public static ISxfElement ReadElement(string data)
    {
        SxfParser sxfParser = new SxfParser(new CommonTokenStream(new SxfLexer(CharStreams.fromString(data))));
        return ReadBlock(sxfParser.file().block());
    }

    public static SxfBlock ToSxfBlock(string data)
    {
        return (SxfBlock) ReadElement(data);
    }

    static SxfBlock ReadBlock(SxfParser.BlockContext block)
    {
        SxfBlock sxfBlock = new SxfBlock();
        foreach (IParseTree variable in block.block_elements().children)
        {
            if (!(variable is SxfParser.VariableContext))
                continue;
            
            SxfParser.VariableContext rawVariable = (SxfParser.VariableContext) variable;

            if (rawVariable.children[0] is SxfParser.Named_basicvarContext)
            {
                SxfParser.Named_basicvarContext namedVar = (SxfParser.Named_basicvarContext) rawVariable.children[0];
                String name = Commons.RemoveQuotes(namedVar.children[0].GetText());
                IParseTree value = namedVar.GetChild(2);
                
                if (value is SxfParser.BlockContext) {
                    sxfBlock.Variables[name] = ReadBlock((SxfParser.BlockContext) value);
                } else {
                    sxfBlock.Variables[name] = ReadVar((SxfParser.Variable_typesContext) value);
                }
                
            }else if (rawVariable.children[0] is SxfParser.Unnamed_objectContext) {
                SxfParser.Unnamed_objectContext unnamedObject = (SxfParser.Unnamed_objectContext) rawVariable.GetChild(0);

                if (unnamedObject.GetChild(0) is SxfParser.BlockContext) {
                    sxfBlock.UnmanagedElements.Add(ReadBlock((SxfParser.BlockContext) unnamedObject.GetChild(0)));
                } else {
                    sxfBlock.UnmanagedElements.Add(ReadStruct((SxfParser.StructContext) unnamedObject.GetChild(0)));
                }
            }
        }

        return sxfBlock;
    }
    
    static SxfStruct ReadStruct(SxfParser.StructContext structContext)
    {
        SxfStruct sxfStruct = new SxfStruct();
        foreach (IParseTree children in structContext.children)
        {
            if (children is SxfParser.Variable_typesContext)
            {
                SxfParser.Variable_typesContext variableType = (SxfParser.Variable_typesContext) children;
                sxfStruct.Elements.Add(ReadVar(variableType));
            }
        }

        return sxfStruct;
    }
    
    static object ReadVar(SxfParser.Variable_typesContext varType)
    {
        IParseTree varTypeRaw = varType.children[0];

        if (varTypeRaw is SxfParser.String_literalContext)
        {
            return Commons.RemoveQuotes(varType.GetText());
        }

        if (varTypeRaw is SxfParser.NumberContext)
        {
            IParseTree numberChildren = varTypeRaw.GetChild(0);
            if (numberChildren is SxfParser.Var_integerContext)
            {
                return int.Parse(numberChildren.GetText());
            } 
            return double.Parse(numberChildren.GetText());
        }

        if (varTypeRaw is SxfParser.BoolContext)
        {
            IParseTree boolContext = varType.GetChild(0);
            return boolContext is SxfParser.Var_trueContext;
        }
        
        if (varTypeRaw is SxfParser.BlockContext)
        {
            return ReadBlock((SxfParser.BlockContext) varTypeRaw);
        }
        
        if (varTypeRaw is SxfParser.StructContext)
        {
            return ReadStruct((SxfParser.StructContext) varTypeRaw); 
        }



        return null;
        
    }
    
}