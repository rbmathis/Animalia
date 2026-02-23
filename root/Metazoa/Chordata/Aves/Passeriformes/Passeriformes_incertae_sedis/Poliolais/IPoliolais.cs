namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Poliolais;

/// <summary>
/// Interface defining characteristics of Poliolais (genus).
/// </summary>
public interface IPoliolais
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
