namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Haletta;

/// <summary>
/// Interface defining characteristics of Haletta (genus).
/// </summary>
public interface IHaletta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
