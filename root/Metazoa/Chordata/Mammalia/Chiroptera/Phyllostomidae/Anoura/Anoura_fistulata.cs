namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura;

/// <summary>
/// Species: Anoura fistulata
/// NCBI TaxId: 2563023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anoura_fistulata : Anoura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anoura fistulata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anoura_fistulata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2563023;
}
