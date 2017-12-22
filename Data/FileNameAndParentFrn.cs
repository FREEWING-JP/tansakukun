
using System;

namespace TansakuKun.Data
{

  public class FileNameAndParentFrn
  {
    private string _name;
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _path = "";
    public string Path
    {
      get { return _path; }
      set { _path = value; }
    }

    private UInt64 _parentFrn;
    public UInt64 ParentFrn
    {
      get { return _parentFrn; }
      set { _parentFrn = value; }
    }

    public FileNameAndParentFrn(string name, UInt64 parentFrn)
    {
      if (name != null && name.Length > 0)
      {
        _name = name;
      }
      else
      {
        throw new ArgumentException("Invalid argument: null or Length = zero", "name");
      }
      if (!(parentFrn < 0))
      {
        _parentFrn = parentFrn;
      }
      else
      {
        throw new ArgumentException("Invalid argument: less than zero", "parentFrn");
      }
    }
  }

}