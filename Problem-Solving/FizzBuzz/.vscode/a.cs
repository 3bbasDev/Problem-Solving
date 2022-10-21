public class aa
{
    public static List<int> predictDays(List<int> day, int k)
    {
        List<int> result=new List<int>();
        
        if(day==null || day.Count==0)
            return result;
        if(day.Count==1)
        {
            result.Add(day[0]);
        }
        else if(day.Count==2)
        {
            if(day[0]<day[1])
            {
                result.Add(day[0]);
                
            }
            if(day[1]<day[0])
            {
                result.Add(day[1]);
                
            }
            
        }
        else
        {
            if(day[0]<day[1])
            {
                result.Add(day[0]);
                
            }
            for(int i=1;i<day.Count;i++)
            {
                if(day[i-1>=day[i]<=day[i+1])
                {
                    result.Add(day[i]);
                }
            }
            if(day[day.Count]<day[day.Count-1])
            {
                result.Add(day[day.Count]);
                
            }
        }
        return result;
    }

}