namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Cirrhigaleus;

/// <summary>
/// Interface defining characteristics of Cirrhigaleus (genus).
/// </summary>
public interface ICirrhigaleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
