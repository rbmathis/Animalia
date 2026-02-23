namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Anaxyrus;

/// <summary>
/// Species: Anaxyrus sp. 'velatus'
/// NCBI TaxId: 302539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anaxyrus_sp_velatus : Anaxyrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anaxyrus sp. 'velatus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anaxyrus_sp_velatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302539;
}
