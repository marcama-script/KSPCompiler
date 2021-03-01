using System;

namespace KSPCompiler.Domain.Ast.Blocks
{
    public partial class AstArgument
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public AstArgument( IAstNode parent )
            : base( AstNodeId.Argument, parent )
        {}

        #region INameable
        public string Name { get; set; } = string.Empty;
        #endregion

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
            // Do nothing
        }
        #endregion IAstNodeAcceptor

    }
}