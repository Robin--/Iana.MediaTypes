using System;
using System.Collections.Generic;
using System.Text;

namespace Iana.MediaTypes
{
    public class Message
    {

        public readonly string CPIM = "message/CPIM"; // [RFC3862]
        public readonly string delivery_status = "message/delivery-status"; // [RFC1894]
        public readonly string disposition_notification = "message/disposition-notification"; // [RFC8098]
        public readonly string example = "message/example"; // [RFC4735]
        public readonly string feedback_report = "message/feedback-report"; // [RFC5965]
        public readonly string global = "message/global"; // [RFC6532]
        public readonly string global_delivery_status = "message/global-delivery-status"; // [RFC6533]
        public readonly string global_disposition_notification = "message/global-disposition-notification"; // [RFC6533]
        public readonly string global_headers = "message/global-headers"; // [RFC6533]
        public readonly string http = "message/http"; // [RFC7230]
        public readonly string imdn_xml = "message/imdn+xml"; // [RFC5438]
        public readonly string s_http = "message/s-http"; // [RFC2660]
        public readonly string sip = "message/sip"; // [RFC3261]
        public readonly string sipfrag = "message/sipfrag"; // [RFC3420]
        public readonly string tracking_status = "message/tracking-status"; // [RFC3886]
        public readonly string vnd_wfa_wsc = "message/vnd.wfa.wsc"; // [Mick_Conley]

    }
}
