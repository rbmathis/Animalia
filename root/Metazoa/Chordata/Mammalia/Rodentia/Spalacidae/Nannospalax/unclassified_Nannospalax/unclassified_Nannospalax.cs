using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Nannospalax;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Nannospalax.unclassified_Nannospalax;

/// <summary>
/// Abstract class for unclassified Nannospalax (no rank).
/// NCBI TaxId: 3160987
/// </summary>
public abstract class unclassified_Nannospalax : Nannospalax, Iunclassified_Nannospalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannospalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3160987;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannospalax";
}
