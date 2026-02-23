namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Porotergus;

/// <summary>
/// Interface defining characteristics of Porotergus (genus).
/// </summary>
public interface IPorotergus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
