namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Catamblyrhynchus;

/// <summary>
/// Interface defining characteristics of Catamblyrhynchus (genus).
/// </summary>
public interface ICatamblyrhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
