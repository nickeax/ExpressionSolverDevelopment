using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums;
public enum TokenType
{
    WHITESPACE,
    NUMERIC,
    IDENTIFIER,
    CONTROL,
    OPERATOR,
    KEYWORD,
    FUNCTION
}
