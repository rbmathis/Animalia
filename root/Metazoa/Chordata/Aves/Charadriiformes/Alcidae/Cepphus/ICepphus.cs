namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Cepphus;

/// <summary>
/// Interface defining characteristics of Cepphus (genus).
/// </summary>
public interface ICepphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
