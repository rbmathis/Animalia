namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersobius;

/// <summary>
/// Interface defining characteristics of Chersobius (genus).
/// </summary>
public interface IChersobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
