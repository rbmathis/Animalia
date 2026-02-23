using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Eptatretus;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Eptatretus.unclassified_Eptatretus;

/// <summary>
/// Abstract class for unclassified Eptatretus (no rank).
/// NCBI TaxId: 2644093
/// </summary>
public abstract class unclassified_Eptatretus : Eptatretus, Iunclassified_Eptatretus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eptatretus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644093;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eptatretus";
}
