// Generated by CodeGenerators/ASTCodeGenerator

namespace KSPCompiler.Domain.Ast.Statements
{
    /// <summary>
    /// AST node representing a variable declaration
    /// </summary>
    public partial class AstVariableDeclaration : AstStatementSyntaxNode, INameable
    {
        #region Fields
        /// <summary>
        /// public string Modifier { get; set; } = string.Empty;
        /// </summary>
        public string Modifier { get; set; } = string.Empty;

        /// <summary>
        /// public AstVariableInitializer? Initializer { get; set; }
        /// </summary>
        public AstVariableInitializer? Initializer { get; set; }

        #endregion Fields

        /// <summary>
        /// Ctor
        /// </summary>
        public AstVariableDeclaration( IAstNode parent )
            : base( AstNodeId.VariableDeclaration, parent )
        {}

        #region INameable
        ///
        /// <inheritdoc/>
        ///
        public string Name { get; set; } = "";
        #endregion INameable

        #region IAstNodeAcceptor

        ///
        /// <inheritdoc/>
        ///
        public override void AcceptChildren<T>( IAstVisitor<T> visitor )
        {
            Initializer?.AcceptChildren( visitor );
        }

        #endregion IAstNodeAcceptor
    }
}