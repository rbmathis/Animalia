using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurinae;

/// <summary>
/// Abstract class for Sciurinae (subfamily).
/// NCBI TaxId: 9991
/// </summary>
public abstract class Sciurinae : Sciuridae, ISciurinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciurinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "subfamily";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9991;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Sciurinae";
}
