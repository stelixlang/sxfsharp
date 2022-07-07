//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/slowcheetah/work_dir/sxfsharp/Sxf.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SxfParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface ISxfListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] SxfParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] SxfParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] SxfParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] SxfParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] SxfParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] SxfParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.named_basicvar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamed_basicvar([NotNull] SxfParser.Named_basicvarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.named_basicvar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamed_basicvar([NotNull] SxfParser.Named_basicvarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.unnamed_object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnnamed_object([NotNull] SxfParser.Unnamed_objectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.unnamed_object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnnamed_object([NotNull] SxfParser.Unnamed_objectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.block_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock_elements([NotNull] SxfParser.Block_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.block_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock_elements([NotNull] SxfParser.Block_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.variable_types"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_types([NotNull] SxfParser.Variable_typesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.variable_types"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_types([NotNull] SxfParser.Variable_typesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] SxfParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] SxfParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.struct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct([NotNull] SxfParser.StructContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.struct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct([NotNull] SxfParser.StructContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.var_integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_integer([NotNull] SxfParser.Var_integerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.var_integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_integer([NotNull] SxfParser.Var_integerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.var_double"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_double([NotNull] SxfParser.Var_doubleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.var_double"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_double([NotNull] SxfParser.Var_doubleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.var_false"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_false([NotNull] SxfParser.Var_falseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.var_false"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_false([NotNull] SxfParser.Var_falseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.var_true"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_true([NotNull] SxfParser.Var_trueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.var_true"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_true([NotNull] SxfParser.Var_trueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.var_null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_null([NotNull] SxfParser.Var_nullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.var_null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_null([NotNull] SxfParser.Var_nullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] SxfParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] SxfParser.BoolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SxfParser.string_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString_literal([NotNull] SxfParser.String_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SxfParser.string_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString_literal([NotNull] SxfParser.String_literalContext context);
}