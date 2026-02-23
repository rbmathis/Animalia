namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys annamensis x Mauremys sinensis
/// NCBI TaxId: 260623
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_annamensis_x_Mauremys_sinensis : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys annamensis x Mauremys sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_annamensis_x_Mauremys_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260623;
}
