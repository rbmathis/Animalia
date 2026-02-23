namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Characodon;

/// <summary>
/// Interface defining characteristics of Characodon (genus).
/// </summary>
public interface ICharacodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
