using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Priolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Priolepis.unclassified_Priolepis;

/// <summary>
/// Abstract class for unclassified Priolepis (no rank).
/// NCBI TaxId: 2619830
/// </summary>
public abstract class unclassified_Priolepis : Priolepis, Iunclassified_Priolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Priolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619830;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Priolepis";
}
