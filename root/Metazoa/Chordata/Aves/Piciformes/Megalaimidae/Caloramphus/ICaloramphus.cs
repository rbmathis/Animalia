namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae.Caloramphus;

/// <summary>
/// Interface defining characteristics of Caloramphus (genus).
/// </summary>
public interface ICaloramphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
