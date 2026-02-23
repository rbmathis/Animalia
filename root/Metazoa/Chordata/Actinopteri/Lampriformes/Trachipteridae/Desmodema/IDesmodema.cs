namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Desmodema;

/// <summary>
/// Interface defining characteristics of Desmodema (genus).
/// </summary>
public interface IDesmodema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
