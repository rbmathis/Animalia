namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricaria;

/// <summary>
/// Species: Loricaria tucumanensis
/// NCBI TaxId: 1748000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loricaria_tucumanensis : Loricaria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loricaria tucumanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loricaria_tucumanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1748000;
}
