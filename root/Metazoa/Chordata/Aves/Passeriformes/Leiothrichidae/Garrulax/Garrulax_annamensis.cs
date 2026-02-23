namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Garrulax;

/// <summary>
/// Species: Garrulax annamensis
/// NCBI TaxId: 2183771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Garrulax_annamensis : Garrulax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Garrulax annamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Garrulax_annamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2183771;
}
