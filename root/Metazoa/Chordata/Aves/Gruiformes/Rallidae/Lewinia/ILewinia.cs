namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Lewinia;

/// <summary>
/// Interface defining characteristics of Lewinia (genus).
/// </summary>
public interface ILewinia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
