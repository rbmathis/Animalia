namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Hephaestus;

/// <summary>
/// Interface defining characteristics of Hephaestus (genus).
/// </summary>
public interface IHephaestus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
