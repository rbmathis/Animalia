namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Melanodryas;

/// <summary>
/// Interface defining characteristics of Melanodryas (genus).
/// </summary>
public interface IMelanodryas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
