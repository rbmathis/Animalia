namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

/// <summary>
/// Species: Pyrrhura albipectus
/// NCBI TaxId: 311894
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhura_albipectus : Pyrrhura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhura albipectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhura_albipectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 311894;
}
