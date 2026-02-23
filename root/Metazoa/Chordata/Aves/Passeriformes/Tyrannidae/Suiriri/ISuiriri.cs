namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Suiriri;

/// <summary>
/// Interface defining characteristics of Suiriri (genus).
/// </summary>
public interface ISuiriri
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
