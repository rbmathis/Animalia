namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Tichodroma;

/// <summary>
/// Interface defining characteristics of Tichodroma (genus).
/// </summary>
public interface ITichodroma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
