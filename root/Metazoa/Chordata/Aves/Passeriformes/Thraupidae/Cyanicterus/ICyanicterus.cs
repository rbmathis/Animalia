namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cyanicterus;

/// <summary>
/// Interface defining characteristics of Cyanicterus (genus).
/// </summary>
public interface ICyanicterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
