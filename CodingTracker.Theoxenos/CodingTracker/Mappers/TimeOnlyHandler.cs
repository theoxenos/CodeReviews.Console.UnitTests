using System.Data;

namespace CodingTracker.Mappers;

public class TimeOnlyHandler : SqlMapper.TypeHandler<TimeOnly>
{
    public override void SetValue(IDbDataParameter parameter, TimeOnly value)
    {
        parameter.Value = value.ToString(Validator.TimeFormat);
    }

    public override TimeOnly Parse(object value)
    {
        return TimeOnly.Parse(value.ToString());
    }
}