namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae.Nycteris;

/// <summary>
/// Species: Nycteris madagascariensis
/// NCBI TaxId: 2860346
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nycteris_madagascariensis : Nycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nycteris madagascariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nycteris_madagascariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2860346;
}
