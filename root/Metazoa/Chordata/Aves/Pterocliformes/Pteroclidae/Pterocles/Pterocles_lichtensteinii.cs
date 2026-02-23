namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pterocliformes.Pteroclidae.Pterocles;

/// <summary>
/// Species: Pterocles lichtensteinii
/// NCBI TaxId: 1811380
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pterocles_lichtensteinii : Pterocles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pterocles lichtensteinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pterocles_lichtensteinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1811380;
}
