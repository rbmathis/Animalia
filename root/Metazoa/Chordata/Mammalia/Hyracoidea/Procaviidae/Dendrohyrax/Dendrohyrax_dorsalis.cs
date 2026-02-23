namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Dendrohyrax;

/// <summary>
/// Species: Dendrohyrax dorsalis
/// NCBI TaxId: 42325
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrohyrax_dorsalis : Dendrohyrax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrohyrax dorsalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrohyrax_dorsalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42325;
}
