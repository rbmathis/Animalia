namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Pelates;

/// <summary>
/// Interface defining characteristics of Pelates (genus).
/// </summary>
public interface IPelates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
