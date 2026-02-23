namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Heteroxenicus;

/// <summary>
/// Interface defining characteristics of Heteroxenicus (genus).
/// </summary>
public interface IHeteroxenicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
