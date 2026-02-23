namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Robsonius;

/// <summary>
/// Interface defining characteristics of Robsonius (genus).
/// </summary>
public interface IRobsonius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
