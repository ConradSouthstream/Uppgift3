using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field.This fired an error!";
        }
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    class LostInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to find what was lost in the field. This fired an error!";
        }
    }
    class BreakintheLawInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to get away with it in a law ruled field. This fired an error!";
        }
    }
    class GRatedInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use some sexy input in a G rated only field. This fired an error!";
        }
    }
}
