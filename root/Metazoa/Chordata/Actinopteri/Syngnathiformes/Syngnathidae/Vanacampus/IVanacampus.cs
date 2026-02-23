namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Vanacampus;

/// <summary>
/// Interface defining characteristics of Vanacampus (genus).
/// </summary>
public interface IVanacampus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
