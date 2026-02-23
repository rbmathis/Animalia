namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dixonius;

/// <summary>
/// Species: Dixonius cf. siamensis
/// NCBI TaxId: 1874901
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dixonius_cf_siamensis : Dixonius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dixonius cf. siamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dixonius_cf_siamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1874901;
}
