namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alipiopsitta;

/// <summary>
/// Species: Alipiopsitta sp.
/// NCBI TaxId: 1661776
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alipiopsitta_sp : Alipiopsitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alipiopsitta sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alipiopsitta_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1661776;
}
