namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Anurolimnas;

/// <summary>
/// Interface defining characteristics of Anurolimnas (genus).
/// </summary>
public interface IAnurolimnas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
