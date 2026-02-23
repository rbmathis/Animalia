using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Dolichopteryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Dolichopteryx.unclassified_Dolichopteryx;

/// <summary>
/// Abstract class for unclassified Dolichopteryx (no rank).
/// NCBI TaxId: 2632368
/// </summary>
public abstract class unclassified_Dolichopteryx : Dolichopteryx, Iunclassified_Dolichopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dolichopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632368;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dolichopteryx";
}
