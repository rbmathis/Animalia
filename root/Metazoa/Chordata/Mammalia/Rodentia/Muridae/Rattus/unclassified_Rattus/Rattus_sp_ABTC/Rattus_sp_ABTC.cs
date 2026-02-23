using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus.unclassified_Rattus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus.unclassified_Rattus.Rattus_sp_ABTC;

/// <summary>
/// Abstract class for Rattus sp. ABTC (no rank).
/// NCBI TaxId: 435434
/// </summary>
public abstract class Rattus_sp_ABTC : unclassified_Rattus, IRattus_sp_ABTC
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rattus sp. ABTC";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Rattus_sp_ABTC";
}
