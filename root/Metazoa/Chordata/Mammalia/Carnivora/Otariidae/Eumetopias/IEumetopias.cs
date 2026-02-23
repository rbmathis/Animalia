namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Eumetopias;

/// <summary>
/// Interface defining characteristics of Eumetopias (genus).
/// </summary>
public interface IEumetopias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
