using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Murinae;

/// <summary>
/// Abstract class for Murinae (subfamily).
/// NCBI TaxId: 39107
/// </summary>
public abstract class Murinae : Muridae, IMurinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Murinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "subfamily";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39107;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Murinae";
}
