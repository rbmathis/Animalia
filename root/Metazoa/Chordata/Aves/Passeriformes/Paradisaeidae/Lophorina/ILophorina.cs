namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Lophorina;

/// <summary>
/// Interface defining characteristics of Lophorina (genus).
/// </summary>
public interface ILophorina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
