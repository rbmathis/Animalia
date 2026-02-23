namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Hiodontiformes.Hiodontidae.Hiodon;

/// <summary>
/// Interface defining characteristics of Hiodon (genus).
/// </summary>
public interface IHiodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
