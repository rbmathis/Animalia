namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Hoplisoma;

/// <summary>
/// Interface defining characteristics of Hoplisoma (genus).
/// </summary>
public interface IHoplisoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
