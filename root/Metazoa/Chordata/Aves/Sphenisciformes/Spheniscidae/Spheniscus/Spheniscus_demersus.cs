namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Spheniscus;

/// <summary>
/// Species: Spheniscus demersus
/// NCBI TaxId: 92683
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spheniscus_demersus : Spheniscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spheniscus demersus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spheniscus_demersus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 92683;
}
