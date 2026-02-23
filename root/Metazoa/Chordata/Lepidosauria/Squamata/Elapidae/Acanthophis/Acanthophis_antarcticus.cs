namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Acanthophis;

/// <summary>
/// Species: Acanthophis antarcticus
/// NCBI TaxId: 8605
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acanthophis_antarcticus : Acanthophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acanthophis antarcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acanthophis_antarcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8605;
}
