namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae.Brachygalba;

/// <summary>
/// Interface defining characteristics of Brachygalba (genus).
/// </summary>
public interface IBrachygalba
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
