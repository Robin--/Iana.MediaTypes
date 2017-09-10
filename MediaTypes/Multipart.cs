using System;
using System.Collections.Generic;
using System.Text;

namespace Iana.MediaTypes
{
    public class Multipart
    {

        public readonly string appledouble = "multipart/appledouble"; // [Patrik_Faltstrom]
        public readonly string byteranges = "multipart/byteranges"; // [RFC7233]
        public readonly string encrypted = "multipart/encrypted"; // [RFC1847]
        public readonly string example = "multipart/example"; // [RFC4735]
        public readonly string form_data = "multipart/form-data"; // [RFC7578]
        public readonly string header_set = "multipart/header-set"; // [Dave_Crocker]
        public readonly string multilingual = "multipart/multilingual"; // [RFC-ietf-slim-multilangcontent-14]
        public readonly string related = "multipart/related"; // [RFC2387]
        public readonly string report = "multipart/report"; // [RFC6522]
        public readonly string signed = "multipart/signed"; // [RFC1847]
        public readonly string vnd_bint_med_plus = "multipart/vnd.bint.med-plus"; // [Heinz-Peter_Schütz]
        public readonly string voice_message = "multipart/voice-message"; // [RFC3801]
        public readonly string x_mixed_replace = "multipart/x-mixed-replace"; // [W3C][Robin_Berjon]

    }
}
