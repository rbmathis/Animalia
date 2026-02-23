using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.unclassified_Thryonomyidae;

/// <summary>
/// Abstract class for unclassified Thryonomyidae (no rank).
/// NCBI TaxId: 2966648
/// </summary>
public abstract class unclassified_Thryonomyidae : Thryonomyidae, Iunclassified_Thryonomyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thryonomyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2966648;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thryonomyidae";
}
