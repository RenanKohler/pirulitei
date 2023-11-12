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
    /// CreateThreadAndRunRequest
    /// </summary>
    [DataContract]
        public partial class CreateThreadAndRunRequest :  IEquatable<CreateThreadAndRunRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadAndRunRequest" /> class.
        /// </summary>
        /// <param name="assistantId">The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run. (required).</param>
        /// <param name="thread">thread.</param>
        /// <param name="model">The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used..</param>
        /// <param name="instructions">Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis..</param>
        /// <param name="tools">Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis..</param>
        /// <param name="metadata">Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. .</param>
        public CreateThreadAndRunRequest(string assistantId = default(string), CreateThreadRequest thread = default(CreateThreadRequest), string model = default(string), string instructions = default(string), List<OneOfCreateThreadAndRunRequestToolsItems> tools = default(List<OneOfCreateThreadAndRunRequestToolsItems>), Object metadata = default(Object))
        {
            // to ensure "assistantId" is required (not null)
            if (assistantId == null)
            {
                throw new InvalidDataException("assistantId is a required property for CreateThreadAndRunRequest and cannot be null");
            }
            else
            {
                this.AssistantId = assistantId;
            }
            this.Thread = thread;
            this.Model = model;
            this.Instructions = instructions;
            this.Tools = tools;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.
        /// </summary>
        /// <value>The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.</value>
        [DataMember(Name="assistant_id", EmitDefaultValue=false)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Gets or Sets Thread
        /// </summary>
        [DataMember(Name="thread", EmitDefaultValue=false)]
        public CreateThreadRequest Thread { get; set; }

        /// <summary>
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.
        /// </summary>
        /// <value>The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        /// <value>Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis.</value>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        /// <value>Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.</value>
        [DataMember(Name="tools", EmitDefaultValue=false)]
        public List<OneOfCreateThreadAndRunRequestToolsItems> Tools { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. 
        /// </summary>
        /// <value>Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateThreadAndRunRequest {\n");
            sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
            sb.Append("  Thread: ").Append(Thread).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  Tools: ").Append(Tools).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as CreateThreadAndRunRequest);
        }

        /// <summary>
        /// Returns true if CreateThreadAndRunRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateThreadAndRunRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateThreadAndRunRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssistantId == input.AssistantId ||
                    (this.AssistantId != null &&
                    this.AssistantId.Equals(input.AssistantId))
                ) && 
                (
                    this.Thread == input.Thread ||
                    (this.Thread != null &&
                    this.Thread.Equals(input.Thread))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
                ) && 
                (
                    this.Tools == input.Tools ||
                    this.Tools != null &&
                    input.Tools != null &&
                    this.Tools.SequenceEqual(input.Tools)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.AssistantId != null)
                    hashCode = hashCode * 59 + this.AssistantId.GetHashCode();
                if (this.Thread != null)
                    hashCode = hashCode * 59 + this.Thread.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.Tools != null)
                    hashCode = hashCode * 59 + this.Tools.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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