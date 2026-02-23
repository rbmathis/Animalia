namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Eopsaltria;

/// <summary>
/// Interface defining characteristics of Eopsaltria (genus).
/// </summary>
public interface IEopsaltria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
