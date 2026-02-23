namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

/// <summary>
/// Species: Pelusios castanoides
/// NCBI TaxId: 904216
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelusios_castanoides : Pelusios
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelusios castanoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelusios_castanoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904216;
}
