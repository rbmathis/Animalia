using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Ambassis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Ambassis.unclassified_Ambassis;

/// <summary>
/// Abstract class for unclassified Ambassis (no rank).
/// NCBI TaxId: 2620063
/// </summary>
public abstract class unclassified_Ambassis : Ambassis, Iunclassified_Ambassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ambassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620063;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ambassis";
}
