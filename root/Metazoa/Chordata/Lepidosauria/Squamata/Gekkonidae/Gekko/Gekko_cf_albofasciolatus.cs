namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko cf. albofasciolatus
/// NCBI TaxId: 2951071
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_cf_albofasciolatus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko cf. albofasciolatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_cf_albofasciolatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2951071;
}
