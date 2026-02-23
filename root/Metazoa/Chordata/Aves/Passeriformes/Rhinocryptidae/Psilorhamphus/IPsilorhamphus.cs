namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Psilorhamphus;

/// <summary>
/// Interface defining characteristics of Psilorhamphus (genus).
/// </summary>
public interface IPsilorhamphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
