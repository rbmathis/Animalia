namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scytalinidae.Scytalina;

/// <summary>
/// Interface defining characteristics of Scytalina (genus).
/// </summary>
public interface IScytalina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
