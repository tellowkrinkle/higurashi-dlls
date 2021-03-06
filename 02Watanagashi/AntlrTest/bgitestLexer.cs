using Antlr.Runtime;
using System;
using System.CodeDom.Compiler;

namespace AntlrTest
{
	[GeneratedCode("ANTLR", "3.5.0.1")]
	[CLSCompliant(false)]
	public class bgitestLexer : Lexer
	{
		private class DFA9 : DFA
		{
			private const string DFA9_eotS = "\u0002\uffff\u0005\a\u0001\uffff\u0001&\u0001\uffff\u0001(\u0004\uffff\u0001*\u0001,\u0001.\v\uffff\u00010\u00013\u00016\u0004\a\u0001;\u0001\a\u0011\uffff\u0004\a\u0001\uffff\u0002\a\u0001C\u0001D\u0001E\u0001\a\u0001G\u0003\uffff\u0001\a\u0001\uffff\u0001\a\u0001J\u0001\uffff";

			private const string DFA9_eofS = "K\uffff";

			private const string DFA9_minS = "\u0001\t\u0001\uffff\u0001A\u0001U\u0001R\u0001l\u0001f\u0001\uffff\u00010\u0001\uffff\u0001*\u0004\uffff\u0001=\u0001|\u0001&\v\uffff\u0002=\u0001<\u0002L\u0001U\u0001s\u00010\u0001c\u0011\uffff\u0001S\u0001L\u0001E\u0001e\u0001\uffff\u0001l\u0001E\u00030\u0001u\u00010\u0003\uffff\u0001d\u0001\uffff\u0001e\u00010\u0001\uffff";

			private const string DFA9_maxS = "\u0001}\u0001\uffff\u0001A\u0001U\u0001R\u0001l\u0001n\u0001\uffff\u00019\u0001\uffff\u0001/\u0004\uffff\u0001=\u0001|\u0001&\v\uffff\u0001=\u0001>\u0001=\u0002L\u0001U\u0001s\u0001z\u0001c\u0011\uffff\u0001S\u0001L\u0001E\u0001e\u0001\uffff\u0001l\u0001E\u0003z\u0001u\u0001z\u0003\uffff\u0001d\u0001\uffff\u0001e\u0001z\u0001\uffff";

			private const string DFA9_acceptS = "\u0001\uffff\u0001\u0001\u0005\uffff\u0001\b\u0001\uffff\u0001\t\u0001\uffff\u0001\v\u0001\f\u0001\r\u0001\u000e\u0003\uffff\u0001\u0014\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\u0019\u0001\u001a\u0001\u001b\u0001\u001c\u0001\u001e\u0001 \t\uffff\u0001\u001d\u0001\n\u0001\u001f\u0001#\u0001\u000f\u0001\u0012\u0001\u0010\u0001\u0013\u0001\u0011\u0001!\u0001\"\u0001'\u0001)\u0001$\u0001&\u0001(\u0001%\u0004\uffff\u0001\u0006\a\uffff\u0001\u0003\u0001\u0004\u0001\u0005\u0001\uffff\u0001\u0002\u0002\uffff\u0001\a";

			private const string DFA9_specialS = "K\uffff}>";

			private static readonly string[] DFA9_transitionS;

			private static readonly short[] DFA9_eot;

			private static readonly short[] DFA9_eof;

			private static readonly char[] DFA9_min;

			private static readonly char[] DFA9_max;

			private static readonly short[] DFA9_accept;

			private static readonly short[] DFA9_special;

			private static readonly short[][] DFA9_transition;

			public override string Description => "1:1: Tokens : ( T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | ID | INT | COMMENT | WS | STRING | CHAR | COMMA | NOT | BWOR | BWAND | OR | AND | RPAREN | LPAREN | HASH | SEMICOLON | RSQ | LSQ | LCURL | RCURL | PLUS | MINUS | TIMES | DIVIDE | MOD | EQ | ASSIGN | NEQ | GTHAN | LTHAN | LEQ | GEQ | SHIFT_LEFT | SHIFT_RIGHT );";

			public DFA9(BaseRecognizer recognizer)
			{
				base.recognizer = recognizer;
				decisionNumber = 9;
				eot = DFA9_eot;
				eof = DFA9_eof;
				min = DFA9_min;
				max = DFA9_max;
				accept = DFA9_accept;
				special = DFA9_special;
				transition = DFA9_transition;
			}

			static DFA9()
			{
				DFA9_transitionS = new string[75]
				{
					"\u0002\v\u0002\uffff\u0001\v\u0012\uffff\u0001\v\u0001\u000f\u0001\f\u0001\u0014\u0001\uffff\u0001\u001c\u0001\u0011\u0001\r\u0001\u0013\u0001\u0012\u0001\u001b\u0001\u001a\u0001\u000e\u0001\b\u0001\u0001\u0001\n\n\t\u0001\uffff\u0001\u0015\u0001\u001f\u0001\u001d\u0001\u001e\u0002\uffff\u0005\a\u0001\u0002\a\a\u0001\u0003\u0005\a\u0001\u0004\u0006\a\u0001\u0017\u0001\uffff\u0001\u0016\u0001\uffff\u0001\a\u0001\uffff\u0004\a\u0001\u0005\u0003\a\u0001\u0006\u0011\a\u0001\u0018\u0001\u0010\u0001\u0019",
					string.Empty,
					"\u0001 ",
					"\u0001!",
					"\u0001\"",
					"\u0001#",
					"\u0001$\a\uffff\u0001%",
					string.Empty,
					"\n\t",
					string.Empty,
					"\u0001'\u0004\uffff\u0001'",
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					"\u0001)",
					"\u0001+",
					"\u0001-",
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					"\u0001/",
					"\u00011\u00012",
					"\u00015\u00014",
					"\u00017",
					"\u00018",
					"\u00019",
					"\u0001:",
					"\n\a\a\uffff\u001a\a\u0004\uffff\u0001\a\u0001\uffff\u001a\a",
					"\u0001<",
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty,
					"\u0001=",
					"\u0001>",
					"\u0001?",
					"\u0001@",
					string.Empty,
					"\u0001A",
					"\u0001B",
					"\n\a\a\uffff\u001a\a\u0004\uffff\u0001\a\u0001\uffff\u001a\a",
					"\n\a\a\uffff\u001a\a\u0004\uffff\u0001\a\u0001\uffff\u001a\a",
					"\n\a\a\uffff\u001a\a\u0004\uffff\u0001\a\u0001\uffff\u001a\a",
					"\u0001F",
					"\n\a\a\uffff\u001a\a\u0004\uffff\u0001\a\u0001\uffff\u001a\a",
					string.Empty,
					string.Empty,
					string.Empty,
					"\u0001H",
					string.Empty,
					"\u0001I",
					"\n\a\a\uffff\u001a\a\u0004\uffff\u0001\a\u0001\uffff\u001a\a",
					string.Empty
				};
				DFA9_eot = DFA.UnpackEncodedString("\u0002\uffff\u0005\a\u0001\uffff\u0001&\u0001\uffff\u0001(\u0004\uffff\u0001*\u0001,\u0001.\v\uffff\u00010\u00013\u00016\u0004\a\u0001;\u0001\a\u0011\uffff\u0004\a\u0001\uffff\u0002\a\u0001C\u0001D\u0001E\u0001\a\u0001G\u0003\uffff\u0001\a\u0001\uffff\u0001\a\u0001J\u0001\uffff");
				DFA9_eof = DFA.UnpackEncodedString("K\uffff");
				DFA9_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\t\u0001\uffff\u0001A\u0001U\u0001R\u0001l\u0001f\u0001\uffff\u00010\u0001\uffff\u0001*\u0004\uffff\u0001=\u0001|\u0001&\v\uffff\u0002=\u0001<\u0002L\u0001U\u0001s\u00010\u0001c\u0011\uffff\u0001S\u0001L\u0001E\u0001e\u0001\uffff\u0001l\u0001E\u00030\u0001u\u00010\u0003\uffff\u0001d\u0001\uffff\u0001e\u00010\u0001\uffff");
				DFA9_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001}\u0001\uffff\u0001A\u0001U\u0001R\u0001l\u0001n\u0001\uffff\u00019\u0001\uffff\u0001/\u0004\uffff\u0001=\u0001|\u0001&\v\uffff\u0001=\u0001>\u0001=\u0002L\u0001U\u0001s\u0001z\u0001c\u0011\uffff\u0001S\u0001L\u0001E\u0001e\u0001\uffff\u0001l\u0001E\u0003z\u0001u\u0001z\u0003\uffff\u0001d\u0001\uffff\u0001e\u0001z\u0001\uffff");
				DFA9_accept = DFA.UnpackEncodedString("\u0001\uffff\u0001\u0001\u0005\uffff\u0001\b\u0001\uffff\u0001\t\u0001\uffff\u0001\v\u0001\f\u0001\r\u0001\u000e\u0003\uffff\u0001\u0014\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\u0019\u0001\u001a\u0001\u001b\u0001\u001c\u0001\u001e\u0001 \t\uffff\u0001\u001d\u0001\n\u0001\u001f\u0001#\u0001\u000f\u0001\u0012\u0001\u0010\u0001\u0013\u0001\u0011\u0001!\u0001\"\u0001'\u0001)\u0001$\u0001&\u0001(\u0001%\u0004\uffff\u0001\u0006\a\uffff\u0001\u0003\u0001\u0004\u0001\u0005\u0001\uffff\u0001\u0002\u0002\uffff\u0001\a");
				DFA9_special = DFA.UnpackEncodedString("K\uffff}>");
				int num = DFA9_transitionS.Length;
				DFA9_transition = new short[num][];
				for (int i = 0; i < num; i++)
				{
					DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
				}
			}

			public override void Error(NoViableAltException nvae)
			{
			}
		}

		public const int EOF = -1;

		public const int AND = 4;

		public const int ASSIGN = 5;

		public const int BLOCK = 6;

		public const int BWAND = 7;

		public const int BWOR = 8;

		public const int CHAR = 9;

		public const int COMMA = 10;

		public const int COMMENT = 11;

		public const int DIVIDE = 12;

		public const int ELSE = 13;

		public const int EQ = 14;

		public const int FALSE = 15;

		public const int GEQ = 16;

		public const int GTHAN = 17;

		public const int HASH = 18;

		public const int ID = 19;

		public const int IF = 20;

		public const int INCLUDE = 21;

		public const int INDEX = 22;

		public const int INT = 23;

		public const int LCURL = 24;

		public const int LEQ = 25;

		public const int LPAREN = 26;

		public const int LSQ = 27;

		public const int LTHAN = 28;

		public const int MEMBER = 29;

		public const int MINUS = 30;

		public const int MOD = 31;

		public const int NEQ = 32;

		public const int NOT = 33;

		public const int OPERATION = 34;

		public const int OR = 35;

		public const int PARAMETERS = 36;

		public const int PLUS = 37;

		public const int RCURL = 38;

		public const int RPAREN = 39;

		public const int RSQ = 40;

		public const int SEMICOLON = 41;

		public const int SHIFT_LEFT = 42;

		public const int SHIFT_RIGHT = 43;

		public const int STRING = 44;

		public const int THEN = 45;

		public const int TIMES = 46;

		public const int TRUE = 47;

		public const int TYPEBOOL = 48;

		public const int TYPEFUNCTION = 49;

		public const int TYPEINT = 50;

		public const int TYPEMATH = 51;

		public const int TYPENULL = 52;

		public const int TYPESTRING = 53;

		public const int TYPEVARIABLE = 54;

		public const int VAR = 55;

		public const int VARDECL = 56;

		public const int WS = 57;

		public const int T__58 = 58;

		public const int T__59 = 59;

		public const int T__60 = 60;

		public const int T__61 = 61;

		public const int T__62 = 62;

		public const int T__63 = 63;

		public const int T__64 = 64;

		private DFA9 dfa9;

		public override string GrammarFileName => "D:\\Projects\\d2bvsdd\\Assets\\Scripts\\Editor\\BGICompiler\\Grammar\\bgitest.g";

		public bgitestLexer()
		{
		}

		public bgitestLexer(ICharStream input)
			: this(input, new RecognizerSharedState())
		{
		}

		public bgitestLexer(ICharStream input, RecognizerSharedState state)
			: base(input, state)
		{
		}

		[GrammarRule("T__58")]
		private void mT__58()
		{
			try
			{
				int type = 58;
				int channel = 0;
				Match(46);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("T__59")]
		private void mT__59()
		{
			try
			{
				int type = 59;
				int channel = 0;
				Match("FALSE");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("T__60")]
		private void mT__60()
		{
			try
			{
				int type = 60;
				int channel = 0;
				Match("NULL");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("T__61")]
		private void mT__61()
		{
			try
			{
				int type = 61;
				int channel = 0;
				Match("TRUE");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("T__62")]
		private void mT__62()
		{
			try
			{
				int type = 62;
				int channel = 0;
				Match("else");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("T__63")]
		private void mT__63()
		{
			try
			{
				int type = 63;
				int channel = 0;
				Match("if");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("T__64")]
		private void mT__64()
		{
			try
			{
				int type = 64;
				int channel = 0;
				Match("include");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("ID")]
		private void mID()
		{
			try
			{
				int type = 19;
				int channel = 0;
				if ((input.LA(1) < 65 || input.LA(1) > 90) && input.LA(1) != 95 && (input.LA(1) < 97 || input.LA(1) > 122))
				{
					MismatchedSetException ex = new MismatchedSetException(null, input);
					Recover(ex);
					throw ex;
				}
				input.Consume();
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							int num2 = input.LA(1);
							if ((num2 >= 48 && num2 <= 57) || (num2 >= 65 && num2 <= 90) || num2 == 95 || (num2 >= 97 && num2 <= 122))
							{
								num = 1;
							}
						}
						finally
						{
						}
						int num3 = num;
						if (num3 != 1)
						{
							break;
						}
						input.Consume();
					}
				}
				finally
				{
				}
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("INT")]
		private void mINT()
		{
			try
			{
				int type = 23;
				int channel = 0;
				int num = 2;
				try
				{
					try
					{
						int num2 = input.LA(1);
						if (num2 == 45)
						{
							num = 1;
						}
					}
					finally
					{
					}
					int num3 = num;
					if (num3 == 1)
					{
						Match(45);
					}
				}
				finally
				{
				}
				int num4 = 0;
				try
				{
					while (true)
					{
						int num5 = 2;
						try
						{
							int num6 = input.LA(1);
							if (num6 >= 48 && num6 <= 57)
							{
								num5 = 1;
							}
						}
						finally
						{
						}
						int num3 = num5;
						if (num3 != 1)
						{
							break;
						}
						input.Consume();
						num4++;
					}
					if (num4 < 1)
					{
						EarlyExitException ex = new EarlyExitException(3, input);
						throw ex;
					}
				}
				finally
				{
				}
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("COMMENT")]
		private void mCOMMENT()
		{
			try
			{
				int type = 11;
				int channel = 0;
				int num = 2;
				try
				{
					int num2 = input.LA(1);
					if (num2 != 47)
					{
						NoViableAltException ex = new NoViableAltException(string.Empty, 7, 0, input, 1);
						throw ex;
					}
					switch (input.LA(2))
					{
					case 47:
						num = 1;
						break;
					case 42:
						num = 2;
						break;
					default:
					{
						NoViableAltException ex2 = new NoViableAltException(string.Empty, 7, 1, input, 2);
						throw ex2;
					}
					}
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
				{
					Match("//");
					try
					{
						while (true)
						{
							int num7 = 2;
							try
							{
								int num8 = input.LA(1);
								if ((num8 >= 0 && num8 <= 9) || (num8 >= 11 && num8 <= 12) || (num8 >= 14 && num8 <= 65535))
								{
									num7 = 1;
								}
							}
							finally
							{
							}
							int num6 = num7;
							if (num6 != 1)
							{
								break;
							}
							input.Consume();
						}
					}
					finally
					{
					}
					int num9 = 2;
					try
					{
						try
						{
							int num10 = input.LA(1);
							if (num10 == 13)
							{
								num9 = 1;
							}
						}
						finally
						{
						}
						int num6 = num9;
						if (num6 == 1)
						{
							Match(13);
						}
					}
					finally
					{
					}
					Match(10);
					Skip();
					break;
				}
				case 2:
					Match("/*");
					try
					{
						while (true)
						{
							int num3 = 2;
							try
							{
								int num4 = input.LA(1);
								if (num4 == 42)
								{
									int num5 = input.LA(2);
									if (num5 == 47)
									{
										num3 = 2;
									}
									else if ((num5 >= 0 && num5 <= 46) || (num5 >= 48 && num5 <= 65535))
									{
										num3 = 1;
									}
								}
								else if ((num4 >= 0 && num4 <= 41) || (num4 >= 43 && num4 <= 65535))
								{
									num3 = 1;
								}
							}
							finally
							{
							}
							int num6 = num3;
							if (num6 != 1)
							{
								break;
							}
							MatchAny();
						}
					}
					finally
					{
					}
					Match("*/");
					Skip();
					break;
				}
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("WS")]
		private void mWS()
		{
			try
			{
				int type = 57;
				int channel = 0;
				if ((input.LA(1) < 9 || input.LA(1) > 10) && input.LA(1) != 13 && input.LA(1) != 32)
				{
					MismatchedSetException ex = new MismatchedSetException(null, input);
					Recover(ex);
					throw ex;
				}
				input.Consume();
				Skip();
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("STRING")]
		private void mSTRING()
		{
			try
			{
				int type = 44;
				int channel = 0;
				Match(34);
				try
				{
					while (true)
					{
						int num = 3;
						try
						{
							int num2 = input.LA(1);
							if (num2 == 92)
							{
								int num3 = input.LA(2);
								if (num3 == 34)
								{
									int num4 = input.LA(3);
									num = ((num4 >= 0 && num4 <= 65535) ? 1 : 2);
								}
								else if ((num3 >= 0 && num3 <= 33) || (num3 >= 35 && num3 <= 65535))
								{
									num = 2;
								}
							}
							else if ((num2 >= 0 && num2 <= 33) || (num2 >= 35 && num2 <= 91) || (num2 >= 93 && num2 <= 65535))
							{
								num = 2;
							}
						}
						finally
						{
						}
						switch (num)
						{
						case 1:
							Match("\\\"");
							continue;
						case 2:
							input.Consume();
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				Match(34);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("CHAR")]
		private void mCHAR()
		{
			try
			{
				int type = 9;
				int channel = 0;
				Match(39);
				if ((input.LA(1) < 0 || input.LA(1) > 38) && (input.LA(1) < 40 || input.LA(1) > 91) && (input.LA(1) < 93 || input.LA(1) > 65535))
				{
					MismatchedSetException ex = new MismatchedSetException(null, input);
					Recover(ex);
					throw ex;
				}
				input.Consume();
				Match(39);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("COMMA")]
		private void mCOMMA()
		{
			try
			{
				int type = 10;
				int channel = 0;
				Match(44);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("NOT")]
		private void mNOT()
		{
			try
			{
				int type = 33;
				int channel = 0;
				Match(33);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("BWOR")]
		private void mBWOR()
		{
			try
			{
				int type = 8;
				int channel = 0;
				Match(124);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("BWAND")]
		private void mBWAND()
		{
			try
			{
				int type = 7;
				int channel = 0;
				Match(38);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("OR")]
		private void mOR()
		{
			try
			{
				int type = 35;
				int channel = 0;
				Match("||");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("AND")]
		private void mAND()
		{
			try
			{
				int type = 4;
				int channel = 0;
				Match("&&");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("RPAREN")]
		private void mRPAREN()
		{
			try
			{
				int type = 39;
				int channel = 0;
				Match(41);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("LPAREN")]
		private void mLPAREN()
		{
			try
			{
				int type = 26;
				int channel = 0;
				Match(40);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("HASH")]
		private void mHASH()
		{
			try
			{
				int type = 18;
				int channel = 0;
				Match(35);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("SEMICOLON")]
		private void mSEMICOLON()
		{
			try
			{
				int type = 41;
				int channel = 0;
				Match(59);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("RSQ")]
		private void mRSQ()
		{
			try
			{
				int type = 40;
				int channel = 0;
				Match(93);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("LSQ")]
		private void mLSQ()
		{
			try
			{
				int type = 27;
				int channel = 0;
				Match(91);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("LCURL")]
		private void mLCURL()
		{
			try
			{
				int type = 24;
				int channel = 0;
				Match(123);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("RCURL")]
		private void mRCURL()
		{
			try
			{
				int type = 38;
				int channel = 0;
				Match(125);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("PLUS")]
		private void mPLUS()
		{
			try
			{
				int type = 37;
				int channel = 0;
				Match(43);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("MINUS")]
		private void mMINUS()
		{
			try
			{
				int type = 30;
				int channel = 0;
				Match(45);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("TIMES")]
		private void mTIMES()
		{
			try
			{
				int type = 46;
				int channel = 0;
				Match(42);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("DIVIDE")]
		private void mDIVIDE()
		{
			try
			{
				int type = 12;
				int channel = 0;
				Match(47);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("MOD")]
		private void mMOD()
		{
			try
			{
				int type = 31;
				int channel = 0;
				Match(37);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("EQ")]
		private void mEQ()
		{
			try
			{
				int type = 14;
				int channel = 0;
				Match("==");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("ASSIGN")]
		private void mASSIGN()
		{
			try
			{
				int type = 5;
				int channel = 0;
				Match(61);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("NEQ")]
		private void mNEQ()
		{
			try
			{
				int type = 32;
				int channel = 0;
				Match("!=");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("GTHAN")]
		private void mGTHAN()
		{
			try
			{
				int type = 17;
				int channel = 0;
				Match(62);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("LTHAN")]
		private void mLTHAN()
		{
			try
			{
				int type = 28;
				int channel = 0;
				Match(60);
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("LEQ")]
		private void mLEQ()
		{
			try
			{
				int type = 25;
				int channel = 0;
				Match("<=");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("GEQ")]
		private void mGEQ()
		{
			try
			{
				int type = 16;
				int channel = 0;
				Match(">=");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("SHIFT_LEFT")]
		private void mSHIFT_LEFT()
		{
			try
			{
				int type = 42;
				int channel = 0;
				Match("<<");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		[GrammarRule("SHIFT_RIGHT")]
		private void mSHIFT_RIGHT()
		{
			try
			{
				int type = 43;
				int channel = 0;
				Match(">>");
				state.type = type;
				state.channel = channel;
			}
			finally
			{
			}
		}

		public override void mTokens()
		{
			int num = 41;
			try
			{
				num = dfa9.Predict(input);
			}
			catch (NoViableAltException)
			{
				throw;
				IL_001d:;
			}
			finally
			{
			}
			switch (num)
			{
			case 1:
				mT__58();
				break;
			case 2:
				mT__59();
				break;
			case 3:
				mT__60();
				break;
			case 4:
				mT__61();
				break;
			case 5:
				mT__62();
				break;
			case 6:
				mT__63();
				break;
			case 7:
				mT__64();
				break;
			case 8:
				mID();
				break;
			case 9:
				mINT();
				break;
			case 10:
				mCOMMENT();
				break;
			case 11:
				mWS();
				break;
			case 12:
				mSTRING();
				break;
			case 13:
				mCHAR();
				break;
			case 14:
				mCOMMA();
				break;
			case 15:
				mNOT();
				break;
			case 16:
				mBWOR();
				break;
			case 17:
				mBWAND();
				break;
			case 18:
				mOR();
				break;
			case 19:
				mAND();
				break;
			case 20:
				mRPAREN();
				break;
			case 21:
				mLPAREN();
				break;
			case 22:
				mHASH();
				break;
			case 23:
				mSEMICOLON();
				break;
			case 24:
				mRSQ();
				break;
			case 25:
				mLSQ();
				break;
			case 26:
				mLCURL();
				break;
			case 27:
				mRCURL();
				break;
			case 28:
				mPLUS();
				break;
			case 29:
				mMINUS();
				break;
			case 30:
				mTIMES();
				break;
			case 31:
				mDIVIDE();
				break;
			case 32:
				mMOD();
				break;
			case 33:
				mEQ();
				break;
			case 34:
				mASSIGN();
				break;
			case 35:
				mNEQ();
				break;
			case 36:
				mGTHAN();
				break;
			case 37:
				mLTHAN();
				break;
			case 38:
				mLEQ();
				break;
			case 39:
				mGEQ();
				break;
			case 40:
				mSHIFT_LEFT();
				break;
			case 41:
				mSHIFT_RIGHT();
				break;
			}
		}

		protected override void InitDFAs()
		{
			base.InitDFAs();
			dfa9 = new DFA9(this);
		}
	}
}
