namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Neopsittacus;

/// <summary>
/// Species: Neopsittacus musschenbroekii
/// NCBI TaxId: 504063
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neopsittacus_musschenbroekii : Neopsittacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neopsittacus musschenbroekii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neopsittacus_musschenbroekii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 504063;
}
