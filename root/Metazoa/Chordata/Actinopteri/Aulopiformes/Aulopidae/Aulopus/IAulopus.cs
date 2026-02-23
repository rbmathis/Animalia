namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Aulopus;

/// <summary>
/// Interface defining characteristics of Aulopus (genus).
/// </summary>
public interface IAulopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
