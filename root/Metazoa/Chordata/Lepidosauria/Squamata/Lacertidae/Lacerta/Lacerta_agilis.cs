namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Lacerta;

/// <summary>
/// Species: Lacerta agilis
/// NCBI TaxId: 80427
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lacerta_agilis : Lacerta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lacerta agilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lacerta_agilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 80427;
}
