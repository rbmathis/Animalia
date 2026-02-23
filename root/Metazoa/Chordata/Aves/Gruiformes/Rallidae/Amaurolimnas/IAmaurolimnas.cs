namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Amaurolimnas;

/// <summary>
/// Interface defining characteristics of Amaurolimnas (genus).
/// </summary>
public interface IAmaurolimnas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
