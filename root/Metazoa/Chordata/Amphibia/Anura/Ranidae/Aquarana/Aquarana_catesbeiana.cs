namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Aquarana;

/// <summary>
/// Species: Aquarana catesbeiana
/// NCBI TaxId: 8400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aquarana_catesbeiana : Aquarana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aquarana catesbeiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aquarana_catesbeiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8400;
}
