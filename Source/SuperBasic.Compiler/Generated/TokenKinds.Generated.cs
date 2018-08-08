// This file is auto-generated by a build task. It shouldn't be edited by hand.

using SuperBasic.Utilities;
using SuperBasic.Utilities.Resources;

namespace SuperBasic.Compiler.Generated
{
    public enum TokenKind
    {
        If,
        Then,
        Else,
        ElseIf,
        EndIf,
        For,
        To,
        Step,
        EndFor,
        While,
        EndWhile,
        Sub,
        EndSub,
        GoTo,
        Or,
        And,
        Dot,
        Comma,
        RightParen,
        LeftParen,
        RightSquareBracket,
        LeftSquareBracket,
        Equal,
        NotEqual,
        Plus,
        Minus,
        Multiply,
        Divide,
        Colon,
        LessThan,
        GreaterThan,
        LessThanOrEqual,
        GreaterThanOrEqual,
        Identifier,
        NumberLiteral,
        StringLiteral,
        Comment,
    }

    public static partial class TokenKindExtensions
    {
        public static string ToDisplayString(this TokenKind kind)
        {
            switch (kind)
            {
                case TokenKind.If: return "If";
                case TokenKind.Then: return "Then";
                case TokenKind.Else: return "Else";
                case TokenKind.ElseIf: return "ElseIf";
                case TokenKind.EndIf: return "EndIf";
                case TokenKind.For: return "For";
                case TokenKind.To: return "To";
                case TokenKind.Step: return "Step";
                case TokenKind.EndFor: return "EndFor";
                case TokenKind.While: return "While";
                case TokenKind.EndWhile: return "EndWhile";
                case TokenKind.Sub: return "Sub";
                case TokenKind.EndSub: return "EndSub";
                case TokenKind.GoTo: return "GoTo";
                case TokenKind.Or: return "Or";
                case TokenKind.And: return "And";
                case TokenKind.Dot: return ".";
                case TokenKind.Comma: return "";
                case TokenKind.RightParen: return ")";
                case TokenKind.LeftParen: return "(";
                case TokenKind.RightSquareBracket: return "]";
                case TokenKind.LeftSquareBracket: return "[";
                case TokenKind.Equal: return "=";
                case TokenKind.NotEqual: return "<>";
                case TokenKind.Plus: return "+";
                case TokenKind.Minus: return "-";
                case TokenKind.Multiply: return "*";
                case TokenKind.Divide: return "/";
                case TokenKind.Colon: return "=";
                case TokenKind.LessThan: return "<";
                case TokenKind.GreaterThan: return ">";
                case TokenKind.LessThanOrEqual: return "<=";
                case TokenKind.GreaterThanOrEqual: return ">=";
                case TokenKind.Identifier: return CompilerResources.TokenKind_Identifier;
                case TokenKind.NumberLiteral: return CompilerResources.TokenKind_NumberLiteral;
                case TokenKind.StringLiteral: return CompilerResources.TokenKind_StringLiteral;
                case TokenKind.Comment: return CompilerResources.TokenKind_Comment;
                default: throw ExceptionUtilities.UnexpectedValue(kind);
            }
        }
    }
}
