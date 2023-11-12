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
    /// Details on the tool outputs needed for this run to continue.
    /// </summary>
    [DataContract]
        public partial class RunObjectRequiredActionSubmitToolOutputs :  IEquatable<RunObjectRequiredActionSubmitToolOutputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredActionSubmitToolOutputs" /> class.
        /// </summary>
        /// <param name="toolCalls">A list of the relevant tool calls. (required).</param>
        public RunObjectRequiredActionSubmitToolOutputs(List<RunToolCallObject> toolCalls = default(List<RunToolCallObject>))
        {
            // to ensure "toolCalls" is required (not null)
            if (toolCalls == null)
            {
                throw new InvalidDataException("toolCalls is a required property for RunObjectRequiredActionSubmitToolOutputs and cannot be null");
            }
            else
            {
                this.ToolCalls = toolCalls;
            }
        }
        
        /// <summary>
        /// A list of the relevant tool calls.
        /// </summary>
        /// <value>A list of the relevant tool calls.</value>
        [DataMember(Name="tool_calls", EmitDefaultValue=false)]
        public List<RunToolCallObject> ToolCalls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunObjectRequiredActionSubmitToolOutputs {\n");
            sb.Append("  ToolCalls: ").Append(ToolCalls).Append("\n");
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
            return this.Equals(input as RunObjectRequiredActionSubmitToolOutputs);
        }

        /// <summary>
        /// Returns true if RunObjectRequiredActionSubmitToolOutputs instances are equal
        /// </summary>
        /// <param name="input">Instance of RunObjectRequiredActionSubmitToolOutputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunObjectRequiredActionSubmitToolOutputs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ToolCalls == input.ToolCalls ||
                    this.ToolCalls != null &&
                    input.ToolCalls != null &&
                    this.ToolCalls.SequenceEqual(input.ToolCalls)
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
                if (this.ToolCalls != null)
                    hashCode = hashCode * 59 + this.ToolCalls.GetHashCode();
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
