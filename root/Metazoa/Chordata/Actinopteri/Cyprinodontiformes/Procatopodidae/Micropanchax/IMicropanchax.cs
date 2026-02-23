namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Micropanchax;

/// <summary>
/// Interface defining characteristics of Micropanchax (genus).
/// </summary>
public interface IMicropanchax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
