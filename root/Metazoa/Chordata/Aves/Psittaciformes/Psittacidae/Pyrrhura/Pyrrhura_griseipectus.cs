namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

/// <summary>
/// Species: Pyrrhura griseipectus
/// NCBI TaxId: 311890
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhura_griseipectus : Pyrrhura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhura griseipectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhura_griseipectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 311890;
}
