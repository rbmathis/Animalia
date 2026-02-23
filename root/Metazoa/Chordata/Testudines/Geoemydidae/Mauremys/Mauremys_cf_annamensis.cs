namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys cf. annamensis
/// NCBI TaxId: 372653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_cf_annamensis : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys cf. annamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_cf_annamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 372653;
}
