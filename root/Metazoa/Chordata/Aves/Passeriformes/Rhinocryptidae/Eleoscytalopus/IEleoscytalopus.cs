namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Eleoscytalopus;

/// <summary>
/// Interface defining characteristics of Eleoscytalopus (genus).
/// </summary>
public interface IEleoscytalopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
