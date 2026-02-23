namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thamnophis;

/// <summary>
/// Species: Thamnophis melanogaster
/// NCBI TaxId: 35011
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thamnophis_melanogaster : Thamnophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thamnophis melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thamnophis_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 35011;
}
