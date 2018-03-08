using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payengine.Controllers
{
    public class Payengine
    {
        public Messages.Postbridge.Bitmap.Message GetPositionMssg() {

            Messages.Postbridge.Bitmap.Message msg = new Messages.Postbridge.Bitmap.Message();
            msg.MessageType = Messages.Postbridge.Enums.MessageTypeEnum.TransactionRequest;

            msg.ProcessingCode = new Messages.Postbridge.Helpers.ProcessingCode("373030");
            return msg;
        }

        public string ProcessPayment() {

            return Guid.NewGuid().ToString();
        }
    }
}
