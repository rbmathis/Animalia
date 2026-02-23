namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Montifringilla;

/// <summary>
/// Interface defining characteristics of Montifringilla (genus).
/// </summary>
public interface IMontifringilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
