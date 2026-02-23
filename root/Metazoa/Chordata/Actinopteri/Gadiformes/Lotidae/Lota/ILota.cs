namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.Lota;

/// <summary>
/// Interface defining characteristics of Lota (genus).
/// </summary>
public interface ILota
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
