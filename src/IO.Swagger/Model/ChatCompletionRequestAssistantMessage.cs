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
    /// ChatCompletionRequestAssistantMessage
    /// </summary>
    [DataContract]
        public partial class ChatCompletionRequestAssistantMessage :  IEquatable<ChatCompletionRequestAssistantMessage>, IValidatableObject, ChatCompletionRequestMessage 
    {
        /// <summary>
        /// The role of the messages author, in this case &#x60;assistant&#x60;.
        /// </summary>
        /// <value>The role of the messages author, in this case &#x60;assistant&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum Assistant for value: assistant
            /// </summary>
            [EnumMember(Value = "assistant")]
            Assistant = 1        }
        /// <summary>
        /// The role of the messages author, in this case &#x60;assistant&#x60;.
        /// </summary>
        /// <value>The role of the messages author, in this case &#x60;assistant&#x60;.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">The contents of the assistant message.  (required).</param>
        /// <param name="role">The role of the messages author, in this case &#x60;assistant&#x60;. (required).</param>
        /// <param name="toolCalls">toolCalls.</param>
        /// <param name="functionCall">functionCall.</param>
        public ChatCompletionRequestAssistantMessage(string content = default(string), RoleEnum role = default(RoleEnum), ChatCompletionMessageToolCalls toolCalls = default(ChatCompletionMessageToolCalls), ChatCompletionRequestAssistantMessageFunctionCall functionCall = default(ChatCompletionRequestAssistantMessageFunctionCall))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for ChatCompletionRequestAssistantMessage and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for ChatCompletionRequestAssistantMessage and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            this.ToolCalls = toolCalls;
            this.FunctionCall = functionCall;
        }
        
        /// <summary>
        /// The contents of the assistant message. 
        /// </summary>
        /// <value>The contents of the assistant message. </value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }


        /// <summary>
        /// Gets or Sets ToolCalls
        /// </summary>
        [DataMember(Name="tool_calls", EmitDefaultValue=false)]
        public ChatCompletionMessageToolCalls ToolCalls { get; set; }

        /// <summary>
        /// Gets or Sets FunctionCall
        /// </summary>
        [DataMember(Name="function_call", EmitDefaultValue=false)]
        public ChatCompletionRequestAssistantMessageFunctionCall FunctionCall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionRequestAssistantMessage {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  ToolCalls: ").Append(ToolCalls).Append("\n");
            sb.Append("  FunctionCall: ").Append(FunctionCall).Append("\n");
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
            return this.Equals(input as ChatCompletionRequestAssistantMessage);
        }

        /// <summary>
        /// Returns true if ChatCompletionRequestAssistantMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatCompletionRequestAssistantMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionRequestAssistantMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.ToolCalls == input.ToolCalls ||
                    (this.ToolCalls != null &&
                    this.ToolCalls.Equals(input.ToolCalls))
                ) && 
                (
                    this.FunctionCall == input.FunctionCall ||
                    (this.FunctionCall != null &&
                    this.FunctionCall.Equals(input.FunctionCall))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.ToolCalls != null)
                    hashCode = hashCode * 59 + this.ToolCalls.GetHashCode();
                if (this.FunctionCall != null)
                    hashCode = hashCode * 59 + this.FunctionCall.GetHashCode();
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
