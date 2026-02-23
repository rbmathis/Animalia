namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Deinagkistrodon;

/// <summary>
/// Interface defining characteristics of Deinagkistrodon (genus).
/// </summary>
public interface IDeinagkistrodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
