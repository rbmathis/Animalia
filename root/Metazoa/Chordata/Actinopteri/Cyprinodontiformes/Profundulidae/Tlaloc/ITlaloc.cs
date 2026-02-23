namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae.Tlaloc;

/// <summary>
/// Interface defining characteristics of Tlaloc (genus).
/// </summary>
public interface ITlaloc
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
