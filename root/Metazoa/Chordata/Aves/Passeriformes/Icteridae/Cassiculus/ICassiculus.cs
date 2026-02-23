namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Cassiculus;

/// <summary>
/// Interface defining characteristics of Cassiculus (genus).
/// </summary>
public interface ICassiculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
