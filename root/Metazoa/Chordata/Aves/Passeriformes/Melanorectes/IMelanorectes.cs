namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanorectes;

/// <summary>
/// Interface defining characteristics of Melanorectes (genus).
/// </summary>
public interface IMelanorectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
