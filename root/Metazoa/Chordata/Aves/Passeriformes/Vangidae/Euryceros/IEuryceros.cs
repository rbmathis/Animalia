namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Euryceros;

/// <summary>
/// Interface defining characteristics of Euryceros (genus).
/// </summary>
public interface IEuryceros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
