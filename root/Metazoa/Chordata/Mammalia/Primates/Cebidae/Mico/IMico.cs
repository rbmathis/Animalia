namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico;

/// <summary>
/// Interface defining characteristics of Mico (genus).
/// </summary>
public interface IMico
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
