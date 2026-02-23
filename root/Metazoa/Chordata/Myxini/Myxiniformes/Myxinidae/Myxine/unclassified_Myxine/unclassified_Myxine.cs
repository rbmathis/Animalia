using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Myxine;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Myxine.unclassified_Myxine;

/// <summary>
/// Abstract class for unclassified Myxine (no rank).
/// NCBI TaxId: 2622193
/// </summary>
public abstract class unclassified_Myxine : Myxine, Iunclassified_Myxine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myxine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622193;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myxine";
}
