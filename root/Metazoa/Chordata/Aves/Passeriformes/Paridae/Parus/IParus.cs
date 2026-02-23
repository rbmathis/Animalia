namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Parus;

/// <summary>
/// Interface defining characteristics of Parus (genus).
/// </summary>
public interface IParus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
