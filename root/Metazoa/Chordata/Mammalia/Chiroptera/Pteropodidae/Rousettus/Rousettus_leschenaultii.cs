namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Rousettus;

/// <summary>
/// Species: Rousettus leschenaultii
/// NCBI TaxId: 9408
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rousettus_leschenaultii : Rousettus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rousettus leschenaultii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rousettus_leschenaultii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9408;
}
