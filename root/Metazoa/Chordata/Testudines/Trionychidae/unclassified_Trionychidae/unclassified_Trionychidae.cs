using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.unclassified_Trionychidae;

/// <summary>
/// Abstract class for unclassified Trionychidae (no rank).
/// NCBI TaxId: 1579217
/// </summary>
public abstract class unclassified_Trionychidae : Trionychidae, Iunclassified_Trionychidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trionychidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1579217;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trionychidae";
}
