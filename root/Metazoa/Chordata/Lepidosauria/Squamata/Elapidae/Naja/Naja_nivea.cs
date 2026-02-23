namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja nivea
/// NCBI TaxId: 8655
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_nivea : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja nivea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_nivea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8655;
}
