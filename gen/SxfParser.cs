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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public partial class SxfParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, INTEGER=7, SET=8, SET_LONG=9, 
		BLOCK_START=10, BLOCK_END=11, SEPARATOR=12, SP_START=13, SP_END=14, IDENTIFIER=15, 
		StringLiteral=16, WS=17, UnterminatedStringLiteral=18, BlockComment=19;
	public const int
		RULE_file = 0, RULE_block = 1, RULE_variable = 2, RULE_named_basicvar = 3, 
		RULE_unnamed_object = 4, RULE_block_elements = 5, RULE_variable_types = 6, 
		RULE_number = 7, RULE_struct = 8, RULE_var_integer = 9, RULE_var_double = 10, 
		RULE_var_false = 11, RULE_var_true = 12, RULE_var_null = 13, RULE_bool = 14, 
		RULE_string_literal = 15;
	public static readonly string[] ruleNames = {
		"file", "block", "variable", "named_basicvar", "unnamed_object", "block_elements", 
		"variable_types", "number", "struct", "var_integer", "var_double", "var_false", 
		"var_true", "var_null", "bool", "string_literal"
	};

	private static readonly string[] _LiteralNames = {
		null, "'.'", "'false'", "'FALSE'", "'true'", "'TRUE'", "'null'", null, 
		"':'", "'=>'", "'{'", "'}'", "','", "'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "INTEGER", "SET", "SET_LONG", 
		"BLOCK_START", "BLOCK_END", "SEPARATOR", "SP_START", "SP_END", "IDENTIFIER", 
		"StringLiteral", "WS", "UnterminatedStringLiteral", "BlockComment"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Sxf.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static SxfParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SxfParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SxfParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterFile(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitFile(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BLOCK_START() { return GetToken(SxfParser.BLOCK_START, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BLOCK_END() { return GetToken(SxfParser.BLOCK_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Block_elementsContext block_elements() {
			return GetRuleContext<Block_elementsContext>(0);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlock(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 2, RULE_block);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34;
			Match(BLOCK_START);
			State = 36;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BLOCK_START) | (1L << SP_START) | (1L << IDENTIFIER) | (1L << StringLiteral))) != 0)) {
				{
				State = 35;
				block_elements();
				}
			}

			State = 38;
			Match(BLOCK_END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Named_basicvarContext named_basicvar() {
			return GetRuleContext<Named_basicvarContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Unnamed_objectContext unnamed_object() {
			return GetRuleContext<Unnamed_objectContext>(0);
		}
		public VariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VariableContext variable() {
		VariableContext _localctx = new VariableContext(Context, State);
		EnterRule(_localctx, 4, RULE_variable);
		try {
			State = 42;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case IDENTIFIER:
			case StringLiteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 40;
				named_basicvar();
				}
				break;
			case BLOCK_START:
			case SP_START:
				EnterOuterAlt(_localctx, 2);
				{
				State = 41;
				unnamed_object();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Named_basicvarContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SxfParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public String_literalContext string_literal() {
			return GetRuleContext<String_literalContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET() { return GetToken(SxfParser.SET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variable_typesContext variable_types() {
			return GetRuleContext<Variable_typesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET_LONG() { return GetToken(SxfParser.SET_LONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public Named_basicvarContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_named_basicvar; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterNamed_basicvar(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitNamed_basicvar(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNamed_basicvar(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Named_basicvarContext named_basicvar() {
		Named_basicvarContext _localctx = new Named_basicvarContext(Context, State);
		EnterRule(_localctx, 6, RULE_named_basicvar);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case IDENTIFIER:
				{
				State = 44;
				Match(IDENTIFIER);
				}
				break;
			case StringLiteral:
				{
				State = 45;
				string_literal();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 52;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SET:
				{
				{
				State = 48;
				Match(SET);
				State = 49;
				variable_types();
				}
				}
				break;
			case SET_LONG:
				{
				{
				State = 50;
				Match(SET_LONG);
				State = 51;
				block();
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Unnamed_objectContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StructContext @struct() {
			return GetRuleContext<StructContext>(0);
		}
		public Unnamed_objectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unnamed_object; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterUnnamed_object(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitUnnamed_object(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnnamed_object(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Unnamed_objectContext unnamed_object() {
		Unnamed_objectContext _localctx = new Unnamed_objectContext(Context, State);
		EnterRule(_localctx, 8, RULE_unnamed_object);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BLOCK_START:
				{
				State = 54;
				block();
				}
				break;
			case SP_START:
				{
				State = 55;
				@struct();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Block_elementsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext[] variable() {
			return GetRuleContexts<VariableContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableContext variable(int i) {
			return GetRuleContext<VariableContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEPARATOR() { return GetTokens(SxfParser.SEPARATOR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEPARATOR(int i) {
			return GetToken(SxfParser.SEPARATOR, i);
		}
		public Block_elementsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block_elements; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterBlock_elements(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitBlock_elements(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlock_elements(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Block_elementsContext block_elements() {
		Block_elementsContext _localctx = new Block_elementsContext(Context, State);
		EnterRule(_localctx, 10, RULE_block_elements);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 58;
			variable();
			State = 63;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SEPARATOR) {
				{
				{
				State = 59;
				Match(SEPARATOR);
				State = 60;
				variable();
				}
				}
				State = 65;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Variable_typesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public String_literalContext string_literal() {
			return GetRuleContext<String_literalContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NumberContext number() {
			return GetRuleContext<NumberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BoolContext @bool() {
			return GetRuleContext<BoolContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StructContext @struct() {
			return GetRuleContext<StructContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Var_nullContext var_null() {
			return GetRuleContext<Var_nullContext>(0);
		}
		public Variable_typesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable_types; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVariable_types(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVariable_types(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariable_types(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Variable_typesContext variable_types() {
		Variable_typesContext _localctx = new Variable_typesContext(Context, State);
		EnterRule(_localctx, 12, RULE_variable_types);
		try {
			State = 72;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case StringLiteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 66;
				string_literal();
				}
				break;
			case INTEGER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 67;
				number();
				}
				break;
			case T__1:
			case T__2:
			case T__3:
			case T__4:
				EnterOuterAlt(_localctx, 3);
				{
				State = 68;
				@bool();
				}
				break;
			case SP_START:
				EnterOuterAlt(_localctx, 4);
				{
				State = 69;
				@struct();
				}
				break;
			case BLOCK_START:
				EnterOuterAlt(_localctx, 5);
				{
				State = 70;
				block();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 6);
				{
				State = 71;
				var_null();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Var_integerContext var_integer() {
			return GetRuleContext<Var_integerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Var_doubleContext var_double() {
			return GetRuleContext<Var_doubleContext>(0);
		}
		public NumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_number; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumberContext number() {
		NumberContext _localctx = new NumberContext(Context, State);
		EnterRule(_localctx, 14, RULE_number);
		try {
			State = 76;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 74;
				var_integer();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 75;
				var_double();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP_START() { return GetToken(SxfParser.SP_START, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP_END() { return GetToken(SxfParser.SP_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variable_typesContext[] variable_types() {
			return GetRuleContexts<Variable_typesContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variable_typesContext variable_types(int i) {
			return GetRuleContext<Variable_typesContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEPARATOR() { return GetTokens(SxfParser.SEPARATOR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEPARATOR(int i) {
			return GetToken(SxfParser.SEPARATOR, i);
		}
		public StructContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterStruct(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitStruct(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStruct(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StructContext @struct() {
		StructContext _localctx = new StructContext(Context, State);
		EnterRule(_localctx, 16, RULE_struct);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78;
			Match(SP_START);
			State = 87;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << INTEGER) | (1L << BLOCK_START) | (1L << SP_START) | (1L << StringLiteral))) != 0)) {
				{
				State = 79;
				variable_types();
				State = 84;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==SEPARATOR) {
					{
					{
					State = 80;
					Match(SEPARATOR);
					State = 81;
					variable_types();
					}
					}
					State = 86;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 89;
			Match(SP_END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_integerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER() { return GetToken(SxfParser.INTEGER, 0); }
		public Var_integerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_var_integer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVar_integer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVar_integer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_integer(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_integerContext var_integer() {
		Var_integerContext _localctx = new Var_integerContext(Context, State);
		EnterRule(_localctx, 18, RULE_var_integer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 91;
			Match(INTEGER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_doubleContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTEGER() { return GetTokens(SxfParser.INTEGER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER(int i) {
			return GetToken(SxfParser.INTEGER, i);
		}
		public Var_doubleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_var_double; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVar_double(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVar_double(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_double(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_doubleContext var_double() {
		Var_doubleContext _localctx = new Var_doubleContext(Context, State);
		EnterRule(_localctx, 20, RULE_var_double);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 93;
			Match(INTEGER);
			State = 94;
			Match(T__0);
			State = 95;
			Match(INTEGER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_falseContext : ParserRuleContext {
		public Var_falseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_var_false; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVar_false(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVar_false(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_false(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_falseContext var_false() {
		Var_falseContext _localctx = new Var_falseContext(Context, State);
		EnterRule(_localctx, 22, RULE_var_false);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 97;
			_la = TokenStream.LA(1);
			if ( !(_la==T__1 || _la==T__2) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_trueContext : ParserRuleContext {
		public Var_trueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_var_true; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVar_true(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVar_true(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_true(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_trueContext var_true() {
		Var_trueContext _localctx = new Var_trueContext(Context, State);
		EnterRule(_localctx, 24, RULE_var_true);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 99;
			_la = TokenStream.LA(1);
			if ( !(_la==T__3 || _la==T__4) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_nullContext : ParserRuleContext {
		public Var_nullContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_var_null; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterVar_null(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitVar_null(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_null(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_nullContext var_null() {
		Var_nullContext _localctx = new Var_nullContext(Context, State);
		EnterRule(_localctx, 26, RULE_var_null);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 101;
			Match(T__5);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BoolContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Var_trueContext var_true() {
			return GetRuleContext<Var_trueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Var_falseContext var_false() {
			return GetRuleContext<Var_falseContext>(0);
		}
		public BoolContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bool; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterBool(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitBool(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBool(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BoolContext @bool() {
		BoolContext _localctx = new BoolContext(Context, State);
		EnterRule(_localctx, 28, RULE_bool);
		try {
			State = 105;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__3:
			case T__4:
				EnterOuterAlt(_localctx, 1);
				{
				State = 103;
				var_true();
				}
				break;
			case T__1:
			case T__2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 104;
				var_false();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class String_literalContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringLiteral() { return GetToken(SxfParser.StringLiteral, 0); }
		public String_literalContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_string_literal; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.EnterString_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISxfListener typedListener = listener as ISxfListener;
			if (typedListener != null) typedListener.ExitString_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISxfVisitor<TResult> typedVisitor = visitor as ISxfVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString_literal(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public String_literalContext string_literal() {
		String_literalContext _localctx = new String_literalContext(Context, State);
		EnterRule(_localctx, 30, RULE_string_literal);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 107;
			Match(StringLiteral);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,19,110,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,7,14,
		2,15,7,15,1,0,1,0,1,1,1,1,3,1,37,8,1,1,1,1,1,1,2,1,2,3,2,43,8,2,1,3,1,
		3,3,3,47,8,3,1,3,1,3,1,3,1,3,3,3,53,8,3,1,4,1,4,3,4,57,8,4,1,5,1,5,1,5,
		5,5,62,8,5,10,5,12,5,65,9,5,1,6,1,6,1,6,1,6,1,6,1,6,3,6,73,8,6,1,7,1,7,
		3,7,77,8,7,1,8,1,8,1,8,1,8,5,8,83,8,8,10,8,12,8,86,9,8,3,8,88,8,8,1,8,
		1,8,1,9,1,9,1,10,1,10,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,
		3,14,106,8,14,1,15,1,15,1,15,0,0,16,0,2,4,6,8,10,12,14,16,18,20,22,24,
		26,28,30,0,2,1,0,2,3,1,0,4,5,108,0,32,1,0,0,0,2,34,1,0,0,0,4,42,1,0,0,
		0,6,46,1,0,0,0,8,56,1,0,0,0,10,58,1,0,0,0,12,72,1,0,0,0,14,76,1,0,0,0,
		16,78,1,0,0,0,18,91,1,0,0,0,20,93,1,0,0,0,22,97,1,0,0,0,24,99,1,0,0,0,
		26,101,1,0,0,0,28,105,1,0,0,0,30,107,1,0,0,0,32,33,3,2,1,0,33,1,1,0,0,
		0,34,36,5,10,0,0,35,37,3,10,5,0,36,35,1,0,0,0,36,37,1,0,0,0,37,38,1,0,
		0,0,38,39,5,11,0,0,39,3,1,0,0,0,40,43,3,6,3,0,41,43,3,8,4,0,42,40,1,0,
		0,0,42,41,1,0,0,0,43,5,1,0,0,0,44,47,5,15,0,0,45,47,3,30,15,0,46,44,1,
		0,0,0,46,45,1,0,0,0,47,52,1,0,0,0,48,49,5,8,0,0,49,53,3,12,6,0,50,51,5,
		9,0,0,51,53,3,2,1,0,52,48,1,0,0,0,52,50,1,0,0,0,53,7,1,0,0,0,54,57,3,2,
		1,0,55,57,3,16,8,0,56,54,1,0,0,0,56,55,1,0,0,0,57,9,1,0,0,0,58,63,3,4,
		2,0,59,60,5,12,0,0,60,62,3,4,2,0,61,59,1,0,0,0,62,65,1,0,0,0,63,61,1,0,
		0,0,63,64,1,0,0,0,64,11,1,0,0,0,65,63,1,0,0,0,66,73,3,30,15,0,67,73,3,
		14,7,0,68,73,3,28,14,0,69,73,3,16,8,0,70,73,3,2,1,0,71,73,3,26,13,0,72,
		66,1,0,0,0,72,67,1,0,0,0,72,68,1,0,0,0,72,69,1,0,0,0,72,70,1,0,0,0,72,
		71,1,0,0,0,73,13,1,0,0,0,74,77,3,18,9,0,75,77,3,20,10,0,76,74,1,0,0,0,
		76,75,1,0,0,0,77,15,1,0,0,0,78,87,5,13,0,0,79,84,3,12,6,0,80,81,5,12,0,
		0,81,83,3,12,6,0,82,80,1,0,0,0,83,86,1,0,0,0,84,82,1,0,0,0,84,85,1,0,0,
		0,85,88,1,0,0,0,86,84,1,0,0,0,87,79,1,0,0,0,87,88,1,0,0,0,88,89,1,0,0,
		0,89,90,5,14,0,0,90,17,1,0,0,0,91,92,5,7,0,0,92,19,1,0,0,0,93,94,5,7,0,
		0,94,95,5,1,0,0,95,96,5,7,0,0,96,21,1,0,0,0,97,98,7,0,0,0,98,23,1,0,0,
		0,99,100,7,1,0,0,100,25,1,0,0,0,101,102,5,6,0,0,102,27,1,0,0,0,103,106,
		3,24,12,0,104,106,3,22,11,0,105,103,1,0,0,0,105,104,1,0,0,0,106,29,1,0,
		0,0,107,108,5,16,0,0,108,31,1,0,0,0,11,36,42,46,52,56,63,72,76,84,87,105
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
