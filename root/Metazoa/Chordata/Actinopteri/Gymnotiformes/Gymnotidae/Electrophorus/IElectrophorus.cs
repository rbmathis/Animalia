namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Electrophorus;

/// <summary>
/// Interface defining characteristics of Electrophorus (genus).
/// </summary>
public interface IElectrophorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
