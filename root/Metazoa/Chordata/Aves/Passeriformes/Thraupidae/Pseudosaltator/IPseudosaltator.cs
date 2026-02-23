namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pseudosaltator;

/// <summary>
/// Interface defining characteristics of Pseudosaltator (genus).
/// </summary>
public interface IPseudosaltator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
