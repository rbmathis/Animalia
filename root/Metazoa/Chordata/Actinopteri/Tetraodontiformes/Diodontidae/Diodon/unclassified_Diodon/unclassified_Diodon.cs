using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Diodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Diodon.unclassified_Diodon;

/// <summary>
/// Abstract class for unclassified Diodon (no rank).
/// NCBI TaxId: 2635078
/// </summary>
public abstract class unclassified_Diodon : Diodon, Iunclassified_Diodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635078;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diodon";
}
