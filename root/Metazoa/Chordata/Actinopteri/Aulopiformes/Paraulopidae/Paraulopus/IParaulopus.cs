namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paraulopidae.Paraulopus;

/// <summary>
/// Interface defining characteristics of Paraulopus (genus).
/// </summary>
public interface IParaulopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
