namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

/// <summary>
/// Species: Pelusios sp. AC-2011
/// NCBI TaxId: 1127752
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelusios_sp_AC_2011 : Pelusios
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelusios sp. AC-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelusios_sp_AC_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1127752;
}
