using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Poliolais;

/// <summary>
/// Abstract class for Poliolais (genus).
/// NCBI TaxId: 1271626
/// </summary>
public abstract class Poliolais : Passeriformes_incertae_sedis, IPoliolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poliolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271626;

    /// <inheritdoc />
    public virtual string GenusName => "Poliolais";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
