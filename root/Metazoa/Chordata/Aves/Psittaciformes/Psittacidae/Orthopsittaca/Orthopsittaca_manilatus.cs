namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Orthopsittaca;

/// <summary>
/// Species: Orthopsittaca manilatus
/// NCBI TaxId: 178890
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Orthopsittaca_manilatus : Orthopsittaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Orthopsittaca manilatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Orthopsittaca_manilatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 178890;
}
