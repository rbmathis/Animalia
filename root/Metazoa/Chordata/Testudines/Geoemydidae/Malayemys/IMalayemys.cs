namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Malayemys;

/// <summary>
/// Interface defining characteristics of Malayemys (genus).
/// </summary>
public interface IMalayemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
