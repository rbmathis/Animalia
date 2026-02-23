using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubrinae;

/// <summary>
/// Abstract class for Colubrinae (subfamily).
/// NCBI TaxId: 169863
/// </summary>
public abstract class Colubrinae : Colubridae, IColubrinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colubrinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "subfamily";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 169863;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Colubrinae";
}
