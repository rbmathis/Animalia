namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Percarina;

/// <summary>
/// Interface defining characteristics of Percarina (genus).
/// </summary>
public interface IPercarina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
