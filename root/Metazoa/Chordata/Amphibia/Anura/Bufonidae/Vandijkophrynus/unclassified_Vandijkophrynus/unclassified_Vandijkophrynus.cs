using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Vandijkophrynus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Vandijkophrynus.unclassified_Vandijkophrynus;

/// <summary>
/// Abstract class for unclassified Vandijkophrynus (no rank).
/// NCBI TaxId: 2644630
/// </summary>
public abstract class unclassified_Vandijkophrynus : Vandijkophrynus, Iunclassified_Vandijkophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vandijkophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644630;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vandijkophrynus";
}
