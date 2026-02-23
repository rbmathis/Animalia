using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Serranobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Serranobatrachus.unclassified_Serranobatrachus;

/// <summary>
/// Abstract class for unclassified Serranobatrachus (no rank).
/// NCBI TaxId: 2993674
/// </summary>
public abstract class unclassified_Serranobatrachus : Serranobatrachus, Iunclassified_Serranobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serranobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2993674;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serranobatrachus";
}
