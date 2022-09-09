


first first = new();

second second = new();

second.MethodOld();




[Obsolete("Use class B")]
class first
{
    public void Method() { }
}


class second
{
    [Obsolete("Use New Method")]
    public void MethodOld() { }

    public void MethodNEw() { }

}