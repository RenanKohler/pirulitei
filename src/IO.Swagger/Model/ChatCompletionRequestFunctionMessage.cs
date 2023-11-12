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
    /// ChatCompletionRequestFunctionMessage
    /// </summary>
    [DataContract]
        public partial class ChatCompletionRequestFunctionMessage :  IEquatable<ChatCompletionRequestFunctionMessage>, IValidatableObject, ChatCompletionRequestMessage 
    {
        /// <summary>
        /// The role of the messages author, in this case &#x60;function&#x60;.
        /// </summary>
        /// <value>The role of the messages author, in this case &#x60;function&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum Function for value: function
            /// </summary>
            [EnumMember(Value = "function")]
            Function = 1        }
        /// <summary>
        /// The role of the messages author, in this case &#x60;function&#x60;.
        /// </summary>
        /// <value>The role of the messages author, in this case &#x60;function&#x60;.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestFunctionMessage" /> class.
        /// </summary>
        /// <param name="role">The role of the messages author, in this case &#x60;function&#x60;. (required).</param>
        /// <param name="content">The return value from the function call, to return to the model. (required).</param>
        /// <param name="name">The name of the function to call. (required).</param>
        public ChatCompletionRequestFunctionMessage(RoleEnum role = default(RoleEnum), string content = default(string), string name = default(string))
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for ChatCompletionRequestFunctionMessage and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for ChatCompletionRequestFunctionMessage and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ChatCompletionRequestFunctionMessage and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        

        /// <summary>
        /// The return value from the function call, to return to the model.
        /// </summary>
        /// <value>The return value from the function call, to return to the model.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        /// <value>The name of the function to call.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionRequestFunctionMessage {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ChatCompletionRequestFunctionMessage);
        }

        /// <summary>
        /// Returns true if ChatCompletionRequestFunctionMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatCompletionRequestFunctionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionRequestFunctionMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
