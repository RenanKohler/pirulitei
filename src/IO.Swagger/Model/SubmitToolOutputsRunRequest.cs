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
    /// SubmitToolOutputsRunRequest
    /// </summary>
    [DataContract]
        public partial class SubmitToolOutputsRunRequest :  IEquatable<SubmitToolOutputsRunRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequest" /> class.
        /// </summary>
        /// <param name="toolOutputs">A list of tools for which the outputs are being submitted. (required).</param>
        public SubmitToolOutputsRunRequest(List<SubmitToolOutputsRunRequestToolOutputs> toolOutputs = default(List<SubmitToolOutputsRunRequestToolOutputs>))
        {
            // to ensure "toolOutputs" is required (not null)
            if (toolOutputs == null)
            {
                throw new InvalidDataException("toolOutputs is a required property for SubmitToolOutputsRunRequest and cannot be null");
            }
            else
            {
                this.ToolOutputs = toolOutputs;
            }
        }
        
        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        /// <value>A list of tools for which the outputs are being submitted.</value>
        [DataMember(Name="tool_outputs", EmitDefaultValue=false)]
        public List<SubmitToolOutputsRunRequestToolOutputs> ToolOutputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitToolOutputsRunRequest {\n");
            sb.Append("  ToolOutputs: ").Append(ToolOutputs).Append("\n");
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
            return this.Equals(input as SubmitToolOutputsRunRequest);
        }

        /// <summary>
        /// Returns true if SubmitToolOutputsRunRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitToolOutputsRunRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitToolOutputsRunRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ToolOutputs == input.ToolOutputs ||
                    this.ToolOutputs != null &&
                    input.ToolOutputs != null &&
                    this.ToolOutputs.SequenceEqual(input.ToolOutputs)
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
                if (this.ToolOutputs != null)
                    hashCode = hashCode * 59 + this.ToolOutputs.GetHashCode();
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
