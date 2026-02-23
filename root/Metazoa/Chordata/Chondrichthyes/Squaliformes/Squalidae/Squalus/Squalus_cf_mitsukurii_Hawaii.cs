namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus cf. mitsukurii Hawaii
/// NCBI TaxId: 1929492
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_cf_mitsukurii_Hawaii : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus cf. mitsukurii Hawaii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_cf_mitsukurii_Hawaii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1929492;
}
