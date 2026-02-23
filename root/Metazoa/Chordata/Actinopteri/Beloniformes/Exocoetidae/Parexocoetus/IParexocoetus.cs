namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Parexocoetus;

/// <summary>
/// Interface defining characteristics of Parexocoetus (genus).
/// </summary>
public interface IParexocoetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
