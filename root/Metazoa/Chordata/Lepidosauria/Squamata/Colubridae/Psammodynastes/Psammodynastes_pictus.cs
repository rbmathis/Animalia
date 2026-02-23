namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Psammodynastes;

/// <summary>
/// Species: Psammodynastes pictus
/// NCBI TaxId: 1899463
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psammodynastes_pictus : Psammodynastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psammodynastes pictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psammodynastes_pictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1899463;
}
