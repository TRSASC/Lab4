using System;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.Phone {
    public enum Sender {
        Taras,
        Jeeves,
        Wooster
    }

    public static class SenderOps {
        /// Randomizer to generate message sender
        public static string GenerateSender() {
            List<Sender> allVals = Enum.GetValues(typeof(Sender)).Cast<Sender>().ToList();
            Random rnd = new Random();
            int resVal = rnd.Next(0, allVals.Count);
            return allVals[resVal].ToString();
        }
    }
}
