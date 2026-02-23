namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sorex;

/// <summary>
/// Species: Sorex sp. AGH-2012
/// NCBI TaxId: 1196408
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sorex_sp_AGH_2012 : Sorex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sorex sp. AGH-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sorex_sp_AGH_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1196408;
}
