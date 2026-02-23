namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Ramphotrigon;

/// <summary>
/// Interface defining characteristics of Ramphotrigon (genus).
/// </summary>
public interface IRamphotrigon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
