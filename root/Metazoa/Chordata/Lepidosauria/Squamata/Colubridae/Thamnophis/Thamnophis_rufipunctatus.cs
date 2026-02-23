namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thamnophis;

/// <summary>
/// Species: Thamnophis rufipunctatus
/// NCBI TaxId: 35016
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thamnophis_rufipunctatus : Thamnophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thamnophis rufipunctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thamnophis_rufipunctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 35016;
}
