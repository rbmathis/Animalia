namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko cf. grossmani
/// NCBI TaxId: 1208033
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_cf_grossmani : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko cf. grossmani";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_cf_grossmani";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1208033;
}
