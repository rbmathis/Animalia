namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Steindachneriidae.Steindachneria;

/// <summary>
/// Interface defining characteristics of Steindachneria (genus).
/// </summary>
public interface ISteindachneria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
