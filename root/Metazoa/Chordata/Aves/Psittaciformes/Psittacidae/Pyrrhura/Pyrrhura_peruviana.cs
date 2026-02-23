namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

/// <summary>
/// Species: Pyrrhura peruviana
/// NCBI TaxId: 311882
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhura_peruviana : Pyrrhura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhura peruviana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhura_peruviana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 311882;
}
