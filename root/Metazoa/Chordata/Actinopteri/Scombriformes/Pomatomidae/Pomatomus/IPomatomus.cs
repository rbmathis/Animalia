namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Pomatomidae.Pomatomus;

/// <summary>
/// Interface defining characteristics of Pomatomus (genus).
/// </summary>
public interface IPomatomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
