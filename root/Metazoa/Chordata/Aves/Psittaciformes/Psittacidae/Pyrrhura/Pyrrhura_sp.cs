namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

/// <summary>
/// Species: Pyrrhura sp.
/// NCBI TaxId: 2797229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhura_sp : Pyrrhura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhura sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhura_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2797229;
}
