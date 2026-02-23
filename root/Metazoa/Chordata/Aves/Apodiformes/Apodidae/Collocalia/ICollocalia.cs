namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Collocalia;

/// <summary>
/// Interface defining characteristics of Collocalia (genus).
/// </summary>
public interface ICollocalia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
