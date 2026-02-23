namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Helostomatidae.Helostoma;

/// <summary>
/// Interface defining characteristics of Helostoma (genus).
/// </summary>
public interface IHelostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
