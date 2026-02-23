namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko cf. palmatus
/// NCBI TaxId: 3476096
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_cf_palmatus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko cf. palmatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_cf_palmatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3476096;
}
