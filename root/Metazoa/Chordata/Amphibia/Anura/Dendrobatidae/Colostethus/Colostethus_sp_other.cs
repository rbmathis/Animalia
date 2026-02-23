namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Colostethus;

/// <summary>
/// Species: Colostethus sp. 'other'
/// NCBI TaxId: 507643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colostethus_sp_other : Colostethus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colostethus sp. 'other'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colostethus_sp_other";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 507643;
}
