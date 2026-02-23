namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Dendrohyrax;

/// <summary>
/// Species: Dendrohyrax sp.
/// NCBI TaxId: 3413537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrohyrax_sp : Dendrohyrax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrohyrax sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrohyrax_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3413537;
}
