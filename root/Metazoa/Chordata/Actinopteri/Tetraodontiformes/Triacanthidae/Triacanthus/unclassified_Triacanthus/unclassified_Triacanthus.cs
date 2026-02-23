using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Triacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Triacanthus.unclassified_Triacanthus;

/// <summary>
/// Abstract class for unclassified Triacanthus (no rank).
/// NCBI TaxId: 2648271
/// </summary>
public abstract class unclassified_Triacanthus : Triacanthus, Iunclassified_Triacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648271;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triacanthus";
}
