namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Brachygalaxias;

/// <summary>
/// Interface defining characteristics of Brachygalaxias (genus).
/// </summary>
public interface IBrachygalaxias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
