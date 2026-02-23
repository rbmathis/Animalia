using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oligolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oligolepis.unclassified_Oligolepis;

/// <summary>
/// Abstract class for unclassified Oligolepis (no rank).
/// NCBI TaxId: 2621328
/// </summary>
public abstract class unclassified_Oligolepis : Oligolepis, Iunclassified_Oligolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oligolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621328;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oligolepis";
}
