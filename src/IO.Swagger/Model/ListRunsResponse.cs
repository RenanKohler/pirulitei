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
    /// ListRunsResponse
    /// </summary>
    [DataContract]
        public partial class ListRunsResponse :  IEquatable<ListRunsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        /// <param name="_object">_object (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="firstId">firstId (required).</param>
        /// <param name="lastId">lastId (required).</param>
        /// <param name="hasMore">hasMore (required).</param>
        public ListRunsResponse(string _object = default(string), List<RunObject> data = default(List<RunObject>), string firstId = default(string), string lastId = default(string), bool? hasMore = default(bool?))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for ListRunsResponse and cannot be null");
            }
            else
            {
                this._Object = _object;
            }
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for ListRunsResponse and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            // to ensure "firstId" is required (not null)
            if (firstId == null)
            {
                throw new InvalidDataException("firstId is a required property for ListRunsResponse and cannot be null");
            }
            else
            {
                this.FirstId = firstId;
            }
            // to ensure "lastId" is required (not null)
            if (lastId == null)
            {
                throw new InvalidDataException("lastId is a required property for ListRunsResponse and cannot be null");
            }
            else
            {
                this.LastId = lastId;
            }
            // to ensure "hasMore" is required (not null)
            if (hasMore == null)
            {
                throw new InvalidDataException("hasMore is a required property for ListRunsResponse and cannot be null");
            }
            else
            {
                this.HasMore = hasMore;
            }
        }
        
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<RunObject> Data { get; set; }

        /// <summary>
        /// Gets or Sets FirstId
        /// </summary>
        [DataMember(Name="first_id", EmitDefaultValue=false)]
        public string FirstId { get; set; }

        /// <summary>
        /// Gets or Sets LastId
        /// </summary>
        [DataMember(Name="last_id", EmitDefaultValue=false)]
        public string LastId { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRunsResponse {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  FirstId: ").Append(FirstId).Append("\n");
            sb.Append("  LastId: ").Append(LastId).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
            return this.Equals(input as ListRunsResponse);
        }

        /// <summary>
        /// Returns true if ListRunsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListRunsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRunsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.FirstId == input.FirstId ||
                    (this.FirstId != null &&
                    this.FirstId.Equals(input.FirstId))
                ) && 
                (
                    this.LastId == input.LastId ||
                    (this.LastId != null &&
                    this.LastId.Equals(input.LastId))
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
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
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.FirstId != null)
                    hashCode = hashCode * 59 + this.FirstId.GetHashCode();
                if (this.LastId != null)
                    hashCode = hashCode * 59 + this.LastId.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
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
