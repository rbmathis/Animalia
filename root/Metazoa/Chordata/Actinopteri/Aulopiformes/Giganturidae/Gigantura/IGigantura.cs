namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Giganturidae.Gigantura;

/// <summary>
/// Interface defining characteristics of Gigantura (genus).
/// </summary>
public interface IGigantura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
