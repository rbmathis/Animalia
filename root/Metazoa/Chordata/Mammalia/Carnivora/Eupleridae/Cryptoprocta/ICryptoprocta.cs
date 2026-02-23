namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Cryptoprocta;

/// <summary>
/// Interface defining characteristics of Cryptoprocta (genus).
/// </summary>
public interface ICryptoprocta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
