namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Pygoscelis;

/// <summary>
/// Species: Pygoscelis antarcticus
/// NCBI TaxId: 79643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pygoscelis_antarcticus : Pygoscelis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pygoscelis antarcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pygoscelis_antarcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79643;
}
