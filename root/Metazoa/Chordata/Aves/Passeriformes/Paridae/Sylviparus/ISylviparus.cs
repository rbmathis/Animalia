namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Sylviparus;

/// <summary>
/// Interface defining characteristics of Sylviparus (genus).
/// </summary>
public interface ISylviparus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
