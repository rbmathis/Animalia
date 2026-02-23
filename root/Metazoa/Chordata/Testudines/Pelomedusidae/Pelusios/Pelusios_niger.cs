namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

/// <summary>
/// Species: Pelusios niger
/// NCBI TaxId: 904220
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelusios_niger : Pelusios
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelusios niger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelusios_niger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904220;
}
