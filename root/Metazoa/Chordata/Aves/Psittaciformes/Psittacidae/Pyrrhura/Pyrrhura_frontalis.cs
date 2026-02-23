namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

/// <summary>
/// Species: Pyrrhura frontalis
/// NCBI TaxId: 211511
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhura_frontalis : Pyrrhura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhura frontalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhura_frontalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 211511;
}
