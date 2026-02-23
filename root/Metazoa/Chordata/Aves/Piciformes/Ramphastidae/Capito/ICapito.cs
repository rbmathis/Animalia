namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Capito;

/// <summary>
/// Interface defining characteristics of Capito (genus).
/// </summary>
public interface ICapito
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
