using KSPCompiler.Domain.Ast.Expressions;

namespace KSPCompiler.Domain.Ast.Blocks
{
    /// <summary>
    /// AST node representing a case block in the select statement
    /// </summary>
    public partial class AstCaseBlock : AstNode
    {
        /// <summary>
        /// Conditional expression for “case" (starting value)
        /// </summary>
        public AstExpressionSyntaxNode ConditionFrom { get; set; } = AstExpressionSyntaxNode.None;

        /// <summary>
        /// Conditional expression for “case" (end value *optional)
        /// </summary>
        public AstExpressionSyntaxNode ConditionTo { get; set; } = AstExpressionSyntaxNode.None;

        /// <summary>
        /// Code block in this“case"
        /// </summary>
        public  AstBlock CodeBlock { get; }

        /// <summary>
        /// Ctor
        /// </summary>
        public AstCaseBlock( IAstNode parent )
            : base( AstNodeId.CaseBlock, parent )
        {
            CodeBlock = new AstBlock( this );
        }

        #region IAstNodeAcceptor
        ///
        /// <inheritdoc/>
        ///
        public override T Accept<T>( IAstVisitor<T> visitor )
        {
            return visitor.Visit( this );
        }

        ///
        /// <inheritdoc/>
        ///
        public override void AcceptChildren<T>( IAstVisitor<T> visitor )
        {
            CodeBlock.AcceptChildren( visitor );
        }
        #endregion IAstNodeAcceptor
    }
}