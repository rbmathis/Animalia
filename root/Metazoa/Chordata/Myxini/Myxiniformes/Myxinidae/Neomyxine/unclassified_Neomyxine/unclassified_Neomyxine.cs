using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Neomyxine;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Neomyxine.unclassified_Neomyxine;

/// <summary>
/// Abstract class for unclassified Neomyxine (no rank).
/// NCBI TaxId: 2621855
/// </summary>
public abstract class unclassified_Neomyxine : Neomyxine, Iunclassified_Neomyxine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neomyxine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621855;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neomyxine";
}
