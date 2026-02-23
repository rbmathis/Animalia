using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis;

/// <summary>
/// Abstract class for Ovalentaria incertae sedis (no rank).
/// NCBI TaxId: 1489909
/// </summary>
public abstract class Ovalentaria_incertae_sedis : Actinopteri, IOvalentaria_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ovalentaria incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489909;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Ovalentaria_incertae_sedis";
}
