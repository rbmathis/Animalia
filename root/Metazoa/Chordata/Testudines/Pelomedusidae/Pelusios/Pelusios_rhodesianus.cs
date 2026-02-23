namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

/// <summary>
/// Species: Pelusios rhodesianus
/// NCBI TaxId: 904223
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelusios_rhodesianus : Pelusios
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelusios rhodesianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelusios_rhodesianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904223;
}
