namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptula;

/// <summary>
/// Species: Eudyptula albosignata
/// NCBI TaxId: 345258
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudyptula_albosignata : Eudyptula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudyptula albosignata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudyptula_albosignata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 345258;
}
