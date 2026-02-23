namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Aenigmatolimnas;

/// <summary>
/// Interface defining characteristics of Aenigmatolimnas (genus).
/// </summary>
public interface IAenigmatolimnas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
