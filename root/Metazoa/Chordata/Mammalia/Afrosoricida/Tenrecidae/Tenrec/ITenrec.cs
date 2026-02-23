namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Tenrec;

/// <summary>
/// Interface defining characteristics of Tenrec (genus).
/// </summary>
public interface ITenrec
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
