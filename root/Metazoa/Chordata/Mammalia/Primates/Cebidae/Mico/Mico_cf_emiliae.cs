namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico;

/// <summary>
/// Species: Mico cf. emiliae
/// NCBI TaxId: 198701
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mico_cf_emiliae : Mico
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mico cf. emiliae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mico_cf_emiliae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 198701;
}
