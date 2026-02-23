namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus;

/// <summary>
/// Interface defining characteristics of Sapajus (genus).
/// </summary>
public interface ISapajus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
