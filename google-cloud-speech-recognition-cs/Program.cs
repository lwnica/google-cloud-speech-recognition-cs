using google_cloud_speech_recognition_cs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace google_cloud_speech_recognition_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //recognize wav file
            string audioFilePath = "audio file path";
            string credentialsFilePath = "credentials file path(json)";
            int samplingRate = 16000;
            Recognize.AsyncRecognizeGcsWordsWithCredentials(audioFilePath, credentialsFilePath,samplingRate);

            //mic reccognition
            int recognitionTime = 100;
            while (true)
            {
                var temp = Recognize.StreamingMicRecognizeAsyncWithCredentials(recognitionTime, credentialsFilePath).Result;
            }

            //tcp streaming recognition (implement in the near future)
        }
    }
}
