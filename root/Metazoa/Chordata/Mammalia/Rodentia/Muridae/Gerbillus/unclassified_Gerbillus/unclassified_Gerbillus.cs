using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillus.unclassified_Gerbillus;

/// <summary>
/// Abstract class for unclassified Gerbillus (no rank).
/// NCBI TaxId: 2622000
/// </summary>
public abstract class unclassified_Gerbillus : Gerbillus, Iunclassified_Gerbillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerbillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622000;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerbillus";
}
