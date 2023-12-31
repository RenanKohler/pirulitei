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
    /// Details on the action required to continue the run. Will be &#x60;null&#x60; if no action is required.
    /// </summary>
    [DataContract]
        public partial class RunObjectRequiredAction :  IEquatable<RunObjectRequiredAction>, IValidatableObject
    {
        /// <summary>
        /// For now, this is always &#x60;submit_tool_outputs&#x60;.
        /// </summary>
        /// <value>For now, this is always &#x60;submit_tool_outputs&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Submittooloutputs for value: submit_tool_outputs
            /// </summary>
            [EnumMember(Value = "submit_tool_outputs")]
            Submittooloutputs = 1        }
        /// <summary>
        /// For now, this is always &#x60;submit_tool_outputs&#x60;.
        /// </summary>
        /// <value>For now, this is always &#x60;submit_tool_outputs&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredAction" /> class.
        /// </summary>
        /// <param name="type">For now, this is always &#x60;submit_tool_outputs&#x60;. (required).</param>
        /// <param name="submitToolOutputs">submitToolOutputs (required).</param>
        public RunObjectRequiredAction(TypeEnum type = default(TypeEnum), RunObjectRequiredActionSubmitToolOutputs submitToolOutputs = default(RunObjectRequiredActionSubmitToolOutputs))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RunObjectRequiredAction and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "submitToolOutputs" is required (not null)
            if (submitToolOutputs == null)
            {
                throw new InvalidDataException("submitToolOutputs is a required property for RunObjectRequiredAction and cannot be null");
            }
            else
            {
                this.SubmitToolOutputs = submitToolOutputs;
            }
        }
        

        /// <summary>
        /// Gets or Sets SubmitToolOutputs
        /// </summary>
        [DataMember(Name="submit_tool_outputs", EmitDefaultValue=false)]
        public RunObjectRequiredActionSubmitToolOutputs SubmitToolOutputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunObjectRequiredAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubmitToolOutputs: ").Append(SubmitToolOutputs).Append("\n");
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
            return this.Equals(input as RunObjectRequiredAction);
        }

        /// <summary>
        /// Returns true if RunObjectRequiredAction instances are equal
        /// </summary>
        /// <param name="input">Instance of RunObjectRequiredAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunObjectRequiredAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SubmitToolOutputs == input.SubmitToolOutputs ||
                    (this.SubmitToolOutputs != null &&
                    this.SubmitToolOutputs.Equals(input.SubmitToolOutputs))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SubmitToolOutputs != null)
                    hashCode = hashCode * 59 + this.SubmitToolOutputs.GetHashCode();
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
