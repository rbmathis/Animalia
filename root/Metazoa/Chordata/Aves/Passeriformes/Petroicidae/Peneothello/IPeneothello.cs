namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Peneothello;

/// <summary>
/// Interface defining characteristics of Peneothello (genus).
/// </summary>
public interface IPeneothello
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
