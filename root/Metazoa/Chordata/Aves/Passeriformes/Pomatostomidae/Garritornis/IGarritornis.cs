namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pomatostomidae.Garritornis;

/// <summary>
/// Interface defining characteristics of Garritornis (genus).
/// </summary>
public interface IGarritornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
