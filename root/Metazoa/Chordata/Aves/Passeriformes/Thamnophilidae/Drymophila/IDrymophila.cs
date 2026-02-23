namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Drymophila;

/// <summary>
/// Interface defining characteristics of Drymophila (genus).
/// </summary>
public interface IDrymophila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
