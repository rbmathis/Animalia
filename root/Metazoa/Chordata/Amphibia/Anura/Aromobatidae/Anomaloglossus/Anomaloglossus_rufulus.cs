namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Anomaloglossus;

/// <summary>
/// Species: Anomaloglossus rufulus
/// NCBI TaxId: 1221493
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anomaloglossus_rufulus : Anomaloglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anomaloglossus rufulus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anomaloglossus_rufulus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1221493;
}
