﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string primeNo(int num);
        [OperationContract]
        string sumOfDigit(int num);
        [OperationContract]
        string reverseString(string value);
        [OperationContract]
        string htmlTags(string valueTag, string htmlData);
        [OperationContract]
        string sortFiveNumbers(int[] num, string sortingNumbers);

    }
}
