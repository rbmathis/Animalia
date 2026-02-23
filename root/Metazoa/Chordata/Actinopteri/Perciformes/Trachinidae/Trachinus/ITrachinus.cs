namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae.Trachinus;

/// <summary>
/// Interface defining characteristics of Trachinus (genus).
/// </summary>
public interface ITrachinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
