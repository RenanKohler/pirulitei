/* 
 * OpenAI API
 *
 * The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// The Code Interpreter tool call definition.
    /// </summary>
    [DataContract]
        public partial class RunStepDetailsToolCallsCodeObjectCodeInterpreter :  IEquatable<RunStepDetailsToolCallsCodeObjectCodeInterpreter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreter" /> class.
        /// </summary>
        /// <param name="input">The input to the Code Interpreter tool call. (required).</param>
        /// <param name="outputs">The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (&#x60;logs&#x60;) or images (&#x60;image&#x60;). Each of these are represented by a different object type. (required).</param>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreter(string input = default(string), List<OneOfRunStepDetailsToolCallsCodeObjectCodeInterpreterOutputsItems> outputs = default(List<OneOfRunStepDetailsToolCallsCodeObjectCodeInterpreterOutputsItems>))
        {
            // to ensure "input" is required (not null)
            if (input == null)
            {
                throw new InvalidDataException("input is a required property for RunStepDetailsToolCallsCodeObjectCodeInterpreter and cannot be null");
            }
            else
            {
                this.Input = input;
            }
            // to ensure "outputs" is required (not null)
            if (outputs == null)
            {
                throw new InvalidDataException("outputs is a required property for RunStepDetailsToolCallsCodeObjectCodeInterpreter and cannot be null");
            }
            else
            {
                this.Outputs = outputs;
            }
        }
        
        /// <summary>
        /// The input to the Code Interpreter tool call.
        /// </summary>
        /// <value>The input to the Code Interpreter tool call.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public string Input { get; set; }

        /// <summary>
        /// The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (&#x60;logs&#x60;) or images (&#x60;image&#x60;). Each of these are represented by a different object type.
        /// </summary>
        /// <value>The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (&#x60;logs&#x60;) or images (&#x60;image&#x60;). Each of these are represented by a different object type.</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<OneOfRunStepDetailsToolCallsCodeObjectCodeInterpreterOutputsItems> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunStepDetailsToolCallsCodeObjectCodeInterpreter {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunStepDetailsToolCallsCodeObjectCodeInterpreter);
        }

        /// <summary>
        /// Returns true if RunStepDetailsToolCallsCodeObjectCodeInterpreter instances are equal
        /// </summary>
        /// <param name="input">Instance of RunStepDetailsToolCallsCodeObjectCodeInterpreter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunStepDetailsToolCallsCodeObjectCodeInterpreter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
