namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Pagophila;

/// <summary>
/// Interface defining characteristics of Pagophila (genus).
/// </summary>
public interface IPagophila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
