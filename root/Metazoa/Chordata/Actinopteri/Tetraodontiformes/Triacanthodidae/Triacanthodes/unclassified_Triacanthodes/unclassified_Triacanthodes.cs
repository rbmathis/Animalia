using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Triacanthodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Triacanthodes.unclassified_Triacanthodes;

/// <summary>
/// Abstract class for unclassified Triacanthodes (no rank).
/// NCBI TaxId: 2646433
/// </summary>
public abstract class unclassified_Triacanthodes : Triacanthodes, Iunclassified_Triacanthodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triacanthodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triacanthodes";
}
