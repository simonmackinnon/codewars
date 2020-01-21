using System;
using System.Collections.Generic;
using System.Linq;

public class DirReduction {
  
    public static string[] dirReduc(String[] arr) {

        List<String> list = new List<String>();

        for (int i = 1; i < arr.Length; i++) {
            if (!isOppositeDir(arr[i], arr[i-1])) {
                list.Add(arr[i-1]);
                list.Add(arr[i]);
                i++;
            }
        }

        String[] arr_ = list.ToArray();

        if (arr.Length == arr_.Length){
            return arr_;
        }
        else {
            return dirReduc(arr_);
        }

    }

    public static bool isOppositeDir(string first, string second) {
        bool ret = false;
        if (first == "NORTH" && second == "SOUTH" || 
            first == "SOUTH" && second == "NORTH" || 
            first == "EAST" && second == "WEST" || 
            first == "WEST" && second == "EAST") {
                ret = true;
            }
         return ret;   
    }
}