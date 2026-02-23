namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Girardinus;

/// <summary>
/// Interface defining characteristics of Girardinus (genus).
/// </summary>
public interface IGirardinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
