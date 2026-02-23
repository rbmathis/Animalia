namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Tenualosa;

/// <summary>
/// Interface defining characteristics of Tenualosa (genus).
/// </summary>
public interface ITenualosa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
