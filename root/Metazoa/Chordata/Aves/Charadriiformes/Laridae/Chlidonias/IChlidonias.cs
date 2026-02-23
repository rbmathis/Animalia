namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Chlidonias;

/// <summary>
/// Interface defining characteristics of Chlidonias (genus).
/// </summary>
public interface IChlidonias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
