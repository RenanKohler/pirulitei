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
    /// ChatCompletionMessageToolCallChunk
    /// </summary>
    [DataContract]
        public partial class ChatCompletionMessageToolCallChunk :  IEquatable<ChatCompletionMessageToolCallChunk>, IValidatableObject
    {
        /// <summary>
        /// The type of the tool. Currently, only &#x60;function&#x60; is supported.
        /// </summary>
        /// <value>The type of the tool. Currently, only &#x60;function&#x60; is supported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Function for value: function
            /// </summary>
            [EnumMember(Value = "function")]
            Function = 1        }
        /// <summary>
        /// The type of the tool. Currently, only &#x60;function&#x60; is supported.
        /// </summary>
        /// <value>The type of the tool. Currently, only &#x60;function&#x60; is supported.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCallChunk" /> class.
        /// </summary>
        /// <param name="index">index (required).</param>
        /// <param name="id">The ID of the tool call..</param>
        /// <param name="type">The type of the tool. Currently, only &#x60;function&#x60; is supported..</param>
        /// <param name="function">function.</param>
        public ChatCompletionMessageToolCallChunk(int? index = default(int?), string id = default(string), TypeEnum? type = default(TypeEnum?), ChatCompletionMessageToolCallChunkFunction function = default(ChatCompletionMessageToolCallChunkFunction))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for ChatCompletionMessageToolCallChunk and cannot be null");
            }
            else
            {
                this.Index = index;
            }
            this.Id = id;
            this.Type = type;
            this.Function = function;
        }
        
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        /// <value>The ID of the tool call.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public ChatCompletionMessageToolCallChunkFunction Function { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionMessageToolCallChunk {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
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
            return this.Equals(input as ChatCompletionMessageToolCallChunk);
        }

        /// <summary>
        /// Returns true if ChatCompletionMessageToolCallChunk instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatCompletionMessageToolCallChunk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionMessageToolCallChunk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
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