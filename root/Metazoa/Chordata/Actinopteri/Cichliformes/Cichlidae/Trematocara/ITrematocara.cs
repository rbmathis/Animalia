namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Trematocara;

/// <summary>
/// Interface defining characteristics of Trematocara (genus).
/// </summary>
public interface ITrematocara
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
