using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Gerbillinae;

/// <summary>
/// Abstract class for unclassified Gerbillinae (no rank).
/// NCBI TaxId: 1090585
/// </summary>
public abstract class unclassified_Gerbillinae : Muridae, Iunclassified_Gerbillinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerbillinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1090585;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerbillinae";
}
