namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Fratercula;

/// <summary>
/// Interface defining characteristics of Fratercula (genus).
/// </summary>
public interface IFratercula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
