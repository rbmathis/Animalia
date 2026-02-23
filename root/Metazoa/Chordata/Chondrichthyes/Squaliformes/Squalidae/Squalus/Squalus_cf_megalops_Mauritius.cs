namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus cf. megalops Mauritius
/// NCBI TaxId: 1929491
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_cf_megalops_Mauritius : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus cf. megalops Mauritius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_cf_megalops_Mauritius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1929491;
}
