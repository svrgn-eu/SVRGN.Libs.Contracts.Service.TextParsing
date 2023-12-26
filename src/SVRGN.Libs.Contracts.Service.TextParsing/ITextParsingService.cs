using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.TextParsing
{
    public interface ITextParsingService
    {
        #region Properties

        #endregion Properties

        #region Methods

        #region RandomizeFromChoiceList: Randomizes a result from a string with the input format "'(255/0/220), 20%', '(76/255/243), 40%', '(255/ 234/ 12), *'" or 'string1, 20%', 'string2, 40%', 'string4, *' or '(255/0/220)', '(76/255/243)', '(255/ 234/ 12)'"
        /// <summary>
        /// Randomizes a result from a string with the input format "'(255/0/220), 20%', '(76/255/243), 40%', '(255/ 234/ 12), *'" or 'string1, 20%', 'string2, 40%', 'string4, *' or '(255/0/220)', '(76/255/243)', '(255/ 234/ 12)'"
        /// </summary>
        /// <param name="Choices">the choices in the input format "'(255/0/220), 20%', '(76/255/243), 40%', '(255/ 234/ 12), *'" or 'string1, 20%', 'string2, 40%', 'string4, *' or '(255/0/220)', '(76/255/243)', '(255/ 234/ 12)'"</param>
        /// <returns>One of the strings in Choices with regards to the possible percent values</returns>
        string RandomizeFromChoiceList(string Choices);
        #endregion RandomizeFromChoiceList

        #region HasCondition
        /// <summary>
        /// indicates if a given text starts with a condition word like 'if' or 'when'
        /// </summary>
        /// <param name="Text">The Text to check</param>
        /// <returns>true, if the text begins with a word indicating a condition like 'if'</returns>
        bool HasCondition(string Text);
        #endregion HasCondition

        List<string> ExtractConditions(string Input, out string Rest);
        string ExtractOrder(string Input);
        string ExtractChoice(string Input);
        List<string> SplitCondition(string Condition);
        string ExtractOrderFromPrimitiveText(string Input);
        string ExtractChoiceFromPrimitiveText(string Input);
        string ExtractLogic(string Input);

        #region SplitLogicItems: will split an input text of the format "when 'Body Shape' = Hourglass then 'Hips'=A,C, D; when 'Body Shape' = Apple then 'Hips'=B, E(25%); " into individual lines like "'Body Shape' = Hourglass|'Hips'=A,C, D"
        /// <summary>
        /// will split an input text of the format "when 'Body Shape' = Hourglass then 'Hips'=A,C, D; when 'Body Shape' = Apple then 'Hips'=B, E(25%); " into individual lines like "'Body Shape' = Hourglass|'Hips'=A,C, D"
        /// </summary>
        /// <param name="Input">the input text</param>
        /// <returns>a list of pipe.seperated strings containing the prerequisite and the consquences for further processing</returns>
        IList<string> SplitLogicItems(string Input);
        #endregion SplitLogicItems

        #region SplitSimpleCondition: splits a simple condition like "Foot Size > 42" into three parts: "Foot Size", ">" and "42"
        /// <summary>
        /// splits a simple condition like "Foot Size > 42" into three parts: "Foot Size", ">" and "42"
        /// </summary>
        /// <param name="Input">the input string</param>
        /// <returns>a list with three items</returns>
        IList<string> SplitSimpleCondition(string Input);
        #endregion SplitSimpleCondition

        #endregion Methods
    }
}
