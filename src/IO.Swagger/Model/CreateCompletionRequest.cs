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
    /// CreateCompletionRequest
    /// </summary>
    [DataContract]
    public partial class CreateCompletionRequest : IEquatable<CreateCompletionRequest>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.  (required).</param>
        /// <param name="prompt">The prompt(s) to generate completions for, encoded as a string, array of strings, array of tokens, or array of token arrays.  Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a prompt is not specified the model will generate as if from the beginning of a new document.  (required) (default to &lt;|endoftext|&gt;).</param>
        /// <param name="bestOf">Generates &#x60;best_of&#x60; completions server-side and returns the \&quot;best\&quot; (the one with the highest log probability per token). Results cannot be streamed.  When used with &#x60;n&#x60;, &#x60;best_of&#x60; controls the number of candidate completions and &#x60;n&#x60; specifies how many to return – &#x60;best_of&#x60; must be greater than &#x60;n&#x60;.  **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for &#x60;max_tokens&#x60; and &#x60;stop&#x60;.  (default to 1).</param>
        /// <param name="echo">Echo back the prompt in addition to the completion  (default to false).</param>
        /// <param name="frequencyPenalty">Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&#x27;s likelihood to repeat the same line verbatim.  [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)  (default to 0).</param>
        /// <param name="logitBias">Modify the likelihood of specified tokens appearing in the completion.  Accepts a JSON object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this [tokenizer tool](/tokenizer?view&#x3D;bpe) (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.  As an example, you can pass &#x60;{\&quot;50256\&quot;: -100}&#x60; to prevent the &lt;|endoftext|&gt; token from being generated. .</param>
        /// <param name="logprobs">Include the log probabilities on the &#x60;logprobs&#x60; most likely tokens, as well the chosen tokens. For example, if &#x60;logprobs&#x60; is 5, the API will return a list of the 5 most likely tokens. The API will always return the &#x60;logprob&#x60; of the sampled token, so there may be up to &#x60;logprobs+1&#x60; elements in the response.  The maximum value for &#x60;logprobs&#x60; is 5. .</param>
        /// <param name="maxTokens">The maximum number of [tokens](/tokenizer) to generate in the completion.  The token count of your prompt plus &#x60;max_tokens&#x60; cannot exceed the model&#x27;s context length. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens.  (default to 16).</param>
        /// <param name="n">How many completions to generate for each prompt.  **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for &#x60;max_tokens&#x60; and &#x60;stop&#x60;.  (default to 1).</param>
        /// <param name="presencePenalty">Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&#x27;s likelihood to talk about new topics.  [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)  (default to 0).</param>
        /// <param name="seed">If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same &#x60;seed&#x60; and parameters should return the same result.  Determinism is not guaranteed, and you should refer to the &#x60;system_fingerprint&#x60; response parameter to monitor changes in the backend. .</param>
        /// <param name="stop">Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence. .</param>
        /// <param name="stream">Whether to stream back partial progress. If set, tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a &#x60;data: [DONE]&#x60; message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).  (default to false).</param>
        /// <param name="suffix">The suffix that comes after a completion of inserted text..</param>
        /// <param name="temperature">What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.  We generally recommend altering this or &#x60;top_p&#x60; but not both.  (default to 1).</param>
        /// <param name="topP">An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or &#x60;temperature&#x60; but not both.  (default to 1).</param>
        /// <param name="user">A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids). .</param>
        public CreateCompletionRequest(AnyOfCreateCompletionRequestModel model = default(AnyOfCreateCompletionRequestModel), OneOfCreateCompletionRequestPrompt prompt = default(OneOfCreateCompletionRequestPrompt), int? bestOf = 1, bool? echo = false, decimal? frequencyPenalty = 0, Dictionary<string, int?> logitBias = default(Dictionary<string, int?>), int? logprobs = default(int?), int? maxTokens = 16, int? n = 1, decimal? presencePenalty = 0, int? seed = default(int?), OneOfCreateCompletionRequestStop stop = default(OneOfCreateCompletionRequestStop), bool? stream = false, string suffix = default(string), decimal? temperature = 1, decimal? topP = 1, string user = default(string))
        {
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for CreateCompletionRequest and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "prompt" is required (not null)
            if (prompt == null)
            {
                throw new InvalidDataException("prompt is a required property for CreateCompletionRequest and cannot be null");
            }
            else
            {
                this.Prompt = prompt;
            }
            // use default value if no "bestOf" provided
            if (bestOf == null)
            {
                this.BestOf = 1;
            }
            else
            {
                this.BestOf = bestOf;
            }
            // use default value if no "echo" provided
            if (echo == null)
            {
                this.Echo = false;
            }
            else
            {
                this.Echo = echo;
            }
            // use default value if no "frequencyPenalty" provided
            if (frequencyPenalty == null)
            {
                this.FrequencyPenalty = 0;
            }
            else
            {
                this.FrequencyPenalty = frequencyPenalty;
            }
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            // use default value if no "maxTokens" provided
            if (maxTokens == null)
            {
                this.MaxTokens = 16;
            }
            else
            {
                this.MaxTokens = maxTokens;
            }
            // use default value if no "n" provided
            if (n == null)
            {
                this.N = 1;
            }
            else
            {
                this.N = n;
            }
            // use default value if no "presencePenalty" provided
            if (presencePenalty == null)
            {
                this.PresencePenalty = 0;
            }
            else
            {
                this.PresencePenalty = presencePenalty;
            }
            this.Seed = seed;
            this.Stop = stop;
            // use default value if no "stream" provided
            if (stream == null)
            {
                this.Stream = false;
            }
            else
            {
                this.Stream = stream;
            }
            this.Suffix = suffix;
            // use default value if no "temperature" provided
            if (temperature == null)
            {
                this.Temperature = 1;
            }
            else
            {
                this.Temperature = temperature;
            }
            // use default value if no "topP" provided
            if (topP == null)
            {
                this.TopP = 1;
            }
            else
            {
                this.TopP = topP;
            }
            this.User = user;
        }

        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. 
        /// </summary>
        /// <value>ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </value>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public AnyOfCreateCompletionRequestModel Model { get; set; }

        /// <summary>
        /// The prompt(s) to generate completions for, encoded as a string, array of strings, array of tokens, or array of token arrays.  Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a prompt is not specified the model will generate as if from the beginning of a new document. 
        /// </summary>
        /// <value>The prompt(s) to generate completions for, encoded as a string, array of strings, array of tokens, or array of token arrays.  Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a prompt is not specified the model will generate as if from the beginning of a new document. </value>
        [DataMember(Name = "prompt", EmitDefaultValue = false)]
        public OneOfCreateCompletionRequestPrompt Prompt { get; set; }

        /// <summary>
        /// Generates &#x60;best_of&#x60; completions server-side and returns the \&quot;best\&quot; (the one with the highest log probability per token). Results cannot be streamed.  When used with &#x60;n&#x60;, &#x60;best_of&#x60; controls the number of candidate completions and &#x60;n&#x60; specifies how many to return – &#x60;best_of&#x60; must be greater than &#x60;n&#x60;.  **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for &#x60;max_tokens&#x60; and &#x60;stop&#x60;. 
        /// </summary>
        /// <value>Generates &#x60;best_of&#x60; completions server-side and returns the \&quot;best\&quot; (the one with the highest log probability per token). Results cannot be streamed.  When used with &#x60;n&#x60;, &#x60;best_of&#x60; controls the number of candidate completions and &#x60;n&#x60; specifies how many to return – &#x60;best_of&#x60; must be greater than &#x60;n&#x60;.  **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for &#x60;max_tokens&#x60; and &#x60;stop&#x60;. </value>
        [DataMember(Name = "best_of", EmitDefaultValue = false)]
        public int? BestOf { get; set; }

        /// <summary>
        /// Echo back the prompt in addition to the completion 
        /// </summary>
        /// <value>Echo back the prompt in addition to the completion </value>
        [DataMember(Name = "echo", EmitDefaultValue = false)]
        public bool? Echo { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&#x27;s likelihood to repeat the same line verbatim.  [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details) 
        /// </summary>
        /// <value>Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&#x27;s likelihood to repeat the same line verbatim.  [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details) </value>
        [DataMember(Name = "frequency_penalty", EmitDefaultValue = false)]
        public decimal? FrequencyPenalty { get; set; }

        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.  Accepts a JSON object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this [tokenizer tool](/tokenizer?view&#x3D;bpe) (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.  As an example, you can pass &#x60;{\&quot;50256\&quot;: -100}&#x60; to prevent the &lt;|endoftext|&gt; token from being generated. 
        /// </summary>
        /// <value>Modify the likelihood of specified tokens appearing in the completion.  Accepts a JSON object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this [tokenizer tool](/tokenizer?view&#x3D;bpe) (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.  As an example, you can pass &#x60;{\&quot;50256\&quot;: -100}&#x60; to prevent the &lt;|endoftext|&gt; token from being generated. </value>
        [DataMember(Name = "logit_bias", EmitDefaultValue = false)]
        public Dictionary<string, int?> LogitBias { get; set; }

        /// <summary>
        /// Include the log probabilities on the &#x60;logprobs&#x60; most likely tokens, as well the chosen tokens. For example, if &#x60;logprobs&#x60; is 5, the API will return a list of the 5 most likely tokens. The API will always return the &#x60;logprob&#x60; of the sampled token, so there may be up to &#x60;logprobs+1&#x60; elements in the response.  The maximum value for &#x60;logprobs&#x60; is 5. 
        /// </summary>
        /// <value>Include the log probabilities on the &#x60;logprobs&#x60; most likely tokens, as well the chosen tokens. For example, if &#x60;logprobs&#x60; is 5, the API will return a list of the 5 most likely tokens. The API will always return the &#x60;logprob&#x60; of the sampled token, so there may be up to &#x60;logprobs+1&#x60; elements in the response.  The maximum value for &#x60;logprobs&#x60; is 5. </value>
        [DataMember(Name = "logprobs", EmitDefaultValue = false)]
        public int? Logprobs { get; set; }

        /// <summary>
        /// The maximum number of [tokens](/tokenizer) to generate in the completion.  The token count of your prompt plus &#x60;max_tokens&#x60; cannot exceed the model&#x27;s context length. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens. 
        /// </summary>
        /// <value>The maximum number of [tokens](/tokenizer) to generate in the completion.  The token count of your prompt plus &#x60;max_tokens&#x60; cannot exceed the model&#x27;s context length. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens. </value>
        [DataMember(Name = "max_tokens", EmitDefaultValue = false)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// How many completions to generate for each prompt.  **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for &#x60;max_tokens&#x60; and &#x60;stop&#x60;. 
        /// </summary>
        /// <value>How many completions to generate for each prompt.  **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for &#x60;max_tokens&#x60; and &#x60;stop&#x60;. </value>
        [DataMember(Name = "n", EmitDefaultValue = false)]
        public int? N { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&#x27;s likelihood to talk about new topics.  [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details) 
        /// </summary>
        /// <value>Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&#x27;s likelihood to talk about new topics.  [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details) </value>
        [DataMember(Name = "presence_penalty", EmitDefaultValue = false)]
        public decimal? PresencePenalty { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same &#x60;seed&#x60; and parameters should return the same result.  Determinism is not guaranteed, and you should refer to the &#x60;system_fingerprint&#x60; response parameter to monitor changes in the backend. 
        /// </summary>
        /// <value>If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same &#x60;seed&#x60; and parameters should return the same result.  Determinism is not guaranteed, and you should refer to the &#x60;system_fingerprint&#x60; response parameter to monitor changes in the backend. </value>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public int? Seed { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence. 
        /// </summary>
        /// <value>Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence. </value>
        [DataMember(Name = "stop", EmitDefaultValue = false)]
        public OneOfCreateCompletionRequestStop Stop { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a &#x60;data: [DONE]&#x60; message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions). 
        /// </summary>
        /// <value>Whether to stream back partial progress. If set, tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a &#x60;data: [DONE]&#x60; message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions). </value>
        [DataMember(Name = "stream", EmitDefaultValue = false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// The suffix that comes after a completion of inserted text.
        /// </summary>
        /// <value>The suffix that comes after a completion of inserted text.</value>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.  We generally recommend altering this or &#x60;top_p&#x60; but not both. 
        /// </summary>
        /// <value>What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.  We generally recommend altering this or &#x60;top_p&#x60; but not both. </value>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or &#x60;temperature&#x60; but not both. 
        /// </summary>
        /// <value>An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or &#x60;temperature&#x60; but not both. </value>
        [DataMember(Name = "top_p", EmitDefaultValue = false)]
        public decimal? TopP { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids). 
        /// </summary>
        /// <value>A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids). </value>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCompletionRequest {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  BestOf: ").Append(BestOf).Append("\n");
            sb.Append("  Echo: ").Append(Echo).Append("\n");
            sb.Append("  FrequencyPenalty: ").Append(FrequencyPenalty).Append("\n");
            sb.Append("  LogitBias: ").Append(LogitBias).Append("\n");
            sb.Append("  Logprobs: ").Append(Logprobs).Append("\n");
            sb.Append("  MaxTokens: ").Append(MaxTokens).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  PresencePenalty: ").Append(PresencePenalty).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  TopP: ").Append(TopP).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as CreateCompletionRequest);
        }

        /// <summary>
        /// Returns true if CreateCompletionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCompletionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCompletionRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) &&
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) &&
                (
                    this.BestOf == input.BestOf ||
                    (this.BestOf != null &&
                    this.BestOf.Equals(input.BestOf))
                ) &&
                (
                    this.Echo == input.Echo ||
                    (this.Echo != null &&
                    this.Echo.Equals(input.Echo))
                ) &&
                (
                    this.FrequencyPenalty == input.FrequencyPenalty ||
                    (this.FrequencyPenalty != null &&
                    this.FrequencyPenalty.Equals(input.FrequencyPenalty))
                ) &&
                (
                    this.LogitBias == input.LogitBias ||
                    this.LogitBias != null &&
                    input.LogitBias != null &&
                    this.LogitBias.SequenceEqual(input.LogitBias)
                ) &&
                (
                    this.Logprobs == input.Logprobs ||
                    (this.Logprobs != null &&
                    this.Logprobs.Equals(input.Logprobs))
                ) &&
                (
                    this.MaxTokens == input.MaxTokens ||
                    (this.MaxTokens != null &&
                    this.MaxTokens.Equals(input.MaxTokens))
                ) &&
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) &&
                (
                    this.PresencePenalty == input.PresencePenalty ||
                    (this.PresencePenalty != null &&
                    this.PresencePenalty.Equals(input.PresencePenalty))
                ) &&
                (
                    this.Seed == input.Seed ||
                    (this.Seed != null &&
                    this.Seed.Equals(input.Seed))
                ) &&
                (
                    this.Stop == input.Stop ||
                    (this.Stop != null &&
                    this.Stop.Equals(input.Stop))
                ) &&
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) &&
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) &&
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) &&
                (
                    this.TopP == input.TopP ||
                    (this.TopP != null &&
                    this.TopP.Equals(input.TopP))
                ) &&
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Prompt != null)
                    hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.BestOf != null)
                    hashCode = hashCode * 59 + this.BestOf.GetHashCode();
                if (this.Echo != null)
                    hashCode = hashCode * 59 + this.Echo.GetHashCode();
                if (this.FrequencyPenalty != null)
                    hashCode = hashCode * 59 + this.FrequencyPenalty.GetHashCode();
                if (this.LogitBias != null)
                    hashCode = hashCode * 59 + this.LogitBias.GetHashCode();
                if (this.Logprobs != null)
                    hashCode = hashCode * 59 + this.Logprobs.GetHashCode();
                if (this.MaxTokens != null)
                    hashCode = hashCode * 59 + this.MaxTokens.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.PresencePenalty != null)
                    hashCode = hashCode * 59 + this.PresencePenalty.GetHashCode();
                if (this.Seed != null)
                    hashCode = hashCode * 59 + this.Seed.GetHashCode();
                if (this.Stop != null)
                    hashCode = hashCode * 59 + this.Stop.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.TopP != null)
                    hashCode = hashCode * 59 + this.TopP.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
