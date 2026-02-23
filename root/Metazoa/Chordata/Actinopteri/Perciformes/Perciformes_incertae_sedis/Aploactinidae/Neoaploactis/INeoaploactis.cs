namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Neoaploactis;

/// <summary>
/// Interface defining characteristics of Neoaploactis (genus).
/// </summary>
public interface INeoaploactis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
