namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura;

/// <summary>
/// Species: Anoura caudifer
/// NCBI TaxId: 27642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anoura_caudifer : Anoura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anoura caudifer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anoura_caudifer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27642;
}
