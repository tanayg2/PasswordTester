using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StringAnalysisService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int VowelCount(string word);

        [OperationContract]
        int UpperCaseCount(string word);

        [OperationContract]
        string Reverse(string word);



        // TODO: Add your service operations here
    }
}
