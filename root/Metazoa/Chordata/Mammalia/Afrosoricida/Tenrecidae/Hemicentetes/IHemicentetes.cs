namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Hemicentetes;

/// <summary>
/// Interface defining characteristics of Hemicentetes (genus).
/// </summary>
public interface IHemicentetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
