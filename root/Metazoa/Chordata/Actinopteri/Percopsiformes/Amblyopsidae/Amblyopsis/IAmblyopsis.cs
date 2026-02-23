namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae.Amblyopsis;

/// <summary>
/// Interface defining characteristics of Amblyopsis (genus).
/// </summary>
public interface IAmblyopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
