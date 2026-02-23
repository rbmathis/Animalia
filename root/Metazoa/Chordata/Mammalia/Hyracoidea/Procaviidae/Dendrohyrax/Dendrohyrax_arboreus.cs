namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Dendrohyrax;

/// <summary>
/// Species: Dendrohyrax arboreus
/// NCBI TaxId: 358129
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrohyrax_arboreus : Dendrohyrax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrohyrax arboreus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrohyrax_arboreus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 358129;
}
