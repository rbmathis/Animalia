using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Dibranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Dibranchus.unclassified_Dibranchus;

/// <summary>
/// Abstract class for unclassified Dibranchus (no rank).
/// NCBI TaxId: 2804016
/// </summary>
public abstract class unclassified_Dibranchus : Dibranchus, Iunclassified_Dibranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dibranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2804016;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dibranchus";
}
