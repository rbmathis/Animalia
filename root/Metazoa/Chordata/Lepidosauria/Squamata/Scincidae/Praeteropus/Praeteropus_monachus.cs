namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Praeteropus;

/// <summary>
/// Species: Praeteropus monachus
/// NCBI TaxId: 2831610
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praeteropus_monachus : Praeteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praeteropus monachus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praeteropus_monachus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2831610;
}
