using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Cataetyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Cataetyx.unclassified_Cataetyx;

/// <summary>
/// Abstract class for unclassified Cataetyx (no rank).
/// NCBI TaxId: 2696546
/// </summary>
public abstract class unclassified_Cataetyx : Cataetyx, Iunclassified_Cataetyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cataetyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696546;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cataetyx";
}
