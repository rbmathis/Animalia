namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

/// <summary>
/// Species: Pelusios broadleyi
/// NCBI TaxId: 904213
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelusios_broadleyi : Pelusios
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelusios broadleyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelusios_broadleyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904213;
}
