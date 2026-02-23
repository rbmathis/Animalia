using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Bryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Bryx.unclassified_Bryx;

/// <summary>
/// Abstract class for unclassified Bryx (no rank).
/// NCBI TaxId: 2649317
/// </summary>
public abstract class unclassified_Bryx : Bryx, Iunclassified_Bryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649317;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryx";
}
