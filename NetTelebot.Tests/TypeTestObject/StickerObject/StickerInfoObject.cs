using NetTelebot.Type;
using NetTelebot.Type.Sticker;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NetTelebot.Tests.TypeTestObject.StickerObject
{
    internal class StickerInfoObject
    {
        [JsonProperty("file_id")]
        internal string FileId { get; set; }

        [JsonProperty("width")]
        internal int Width { get; set; }

        [JsonProperty("height")]
        internal int Height { get; set; }

        [JsonProperty("thumb")]
        internal PhotoSizeInfoObjects Thumb { get; set; }

        [JsonProperty("emoji")]
        internal string Emoji { get; set; }

        [JsonProperty("set_name")]
        internal string SetName { get; set; }

        [JsonProperty("mask_position")]
        internal MaskPositiontInfoObject MaskPosition { get; set; }

        [JsonProperty("file_size")]
        internal int FileSize { get; set; }
        
        /// <summary>
        /// This object represents a sticker for test. See <see href="https://core.telegram.org/bots/api#sticker">API</see>
        /// </summary>
        /// <param name="fileId">Unique identifier for this file. Json field [file_id].</param>
        /// <param name="width">Sticker width. Json field [width].</param>
        /// <param name="height">Sticker height. Json field [height].</param>
        /// <param name="photoSizeInfo">Optional. Sticker thumbnail in .webp or .jpg format. 
        /// To simulate <see cref="PhotoSizeInfo"/> use <see cref="PhotoSizeInfoObject"/>. Json field [thumb].</param>
        /// <param name="emoji">Optional. Emoji associated with the sticker.</param>
        /// <param name="setName"></param>
        /// <param name="maskPosition"></param>
        /// <param name="fileSize">Optional. File size.</param>
        /// <returns><see cref="StickerInfo"/></returns>
        internal static JObject GetObject(string fileId, int width, int height, JObject photoSizeInfo,
            string emoji, string setName, JObject maskPosition, int fileSize)
        {
            dynamic stickerInfo = new JObject();

            stickerInfo.file_id = fileId;
            stickerInfo.width = width;
            stickerInfo.height = height;
            stickerInfo.thumb = photoSizeInfo;
            stickerInfo.emoji = emoji;
            stickerInfo.set_name = setName;
            stickerInfo.mask_position = maskPosition;
            stickerInfo.file_size = fileSize;

            return stickerInfo;
        }
    }
}
