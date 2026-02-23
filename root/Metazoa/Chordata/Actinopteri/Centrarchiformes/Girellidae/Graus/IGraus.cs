namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Girellidae.Graus;

/// <summary>
/// Interface defining characteristics of Graus (genus).
/// </summary>
public interface IGraus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
