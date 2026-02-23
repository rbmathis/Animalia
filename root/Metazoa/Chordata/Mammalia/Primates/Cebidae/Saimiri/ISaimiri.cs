namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saimiri;

/// <summary>
/// Interface defining characteristics of Saimiri (genus).
/// </summary>
public interface ISaimiri
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
