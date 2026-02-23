namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Lacustricola;

/// <summary>
/// Interface defining characteristics of Lacustricola (genus).
/// </summary>
public interface ILacustricola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
