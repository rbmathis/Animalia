using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetinae;

/// <summary>
/// Abstract class for Cricetinae (subfamily).
/// NCBI TaxId: 10026
/// </summary>
public abstract class Cricetinae : Cricetidae, ICricetinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cricetinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "subfamily";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10026;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cricetinae";
}
