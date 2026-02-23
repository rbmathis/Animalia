namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Aspidophoroides;

/// <summary>
/// Interface defining characteristics of Aspidophoroides (genus).
/// </summary>
public interface IAspidophoroides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
