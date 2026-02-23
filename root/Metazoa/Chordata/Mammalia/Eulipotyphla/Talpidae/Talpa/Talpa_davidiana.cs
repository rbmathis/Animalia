namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

/// <summary>
/// Species: Talpa davidiana
/// NCBI TaxId: 1607695
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Talpa_davidiana : Talpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Talpa davidiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Talpa_davidiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1607695;
}
