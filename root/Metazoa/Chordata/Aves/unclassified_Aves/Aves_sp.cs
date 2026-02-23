namespace AnimalKingdom.root.Metazoa.Chordata.Aves.unclassified_Aves;

/// <summary>
/// Species: Aves sp.
/// NCBI TaxId: 1885052
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aves_sp : unclassified_Aves
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aves sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aves_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1885052;
}
