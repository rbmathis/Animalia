namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Caretta;

/// <summary>
/// Interface defining characteristics of Caretta (genus).
/// </summary>
public interface ICaretta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
