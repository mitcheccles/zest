﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.CodeGenerator.Visitor.Nodes
{
    class EndNode : IAstNode
    {
        public void Accept(INodeVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
