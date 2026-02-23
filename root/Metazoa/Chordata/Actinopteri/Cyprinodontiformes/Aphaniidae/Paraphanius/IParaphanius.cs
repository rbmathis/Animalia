namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Paraphanius;

/// <summary>
/// Interface defining characteristics of Paraphanius (genus).
/// </summary>
public interface IParaphanius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
