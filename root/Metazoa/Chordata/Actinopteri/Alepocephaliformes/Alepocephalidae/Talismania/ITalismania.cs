namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Talismania;

/// <summary>
/// Interface defining characteristics of Talismania (genus).
/// </summary>
public interface ITalismania
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
