namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Rogadius;

/// <summary>
/// Interface defining characteristics of Rogadius (genus).
/// </summary>
public interface IRogadius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
