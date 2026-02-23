namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Indri;

/// <summary>
/// Interface defining characteristics of Indri (genus).
/// </summary>
public interface IIndri
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
