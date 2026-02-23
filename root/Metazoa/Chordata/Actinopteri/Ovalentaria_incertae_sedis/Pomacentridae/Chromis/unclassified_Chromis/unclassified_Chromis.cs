using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chromis.unclassified_Chromis;

/// <summary>
/// Abstract class for unclassified Chromis (no rank).
/// NCBI TaxId: 2619429
/// </summary>
public abstract class unclassified_Chromis : Chromis, Iunclassified_Chromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619429;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chromis";
}
