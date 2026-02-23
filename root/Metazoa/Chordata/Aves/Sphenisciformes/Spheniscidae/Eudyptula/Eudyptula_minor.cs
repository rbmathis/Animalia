namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptula;

/// <summary>
/// Species: Eudyptula minor
/// NCBI TaxId: 37083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudyptula_minor : Eudyptula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudyptula minor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudyptula_minor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37083;
}
