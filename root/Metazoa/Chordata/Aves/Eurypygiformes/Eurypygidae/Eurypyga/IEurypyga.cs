namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Eurypygiformes.Eurypygidae.Eurypyga;

/// <summary>
/// Interface defining characteristics of Eurypyga (genus).
/// </summary>
public interface IEurypyga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
