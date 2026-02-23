namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Carpospiza;

/// <summary>
/// Interface defining characteristics of Carpospiza (genus).
/// </summary>
public interface ICarpospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
