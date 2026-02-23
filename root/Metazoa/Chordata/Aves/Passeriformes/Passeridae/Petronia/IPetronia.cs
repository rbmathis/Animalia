namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Petronia;

/// <summary>
/// Interface defining characteristics of Petronia (genus).
/// </summary>
public interface IPetronia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
