namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Recurvirostra;

/// <summary>
/// Species: Recurvirostra novaehollandiae
/// NCBI TaxId: 2202208
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Recurvirostra_novaehollandiae : Recurvirostra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Recurvirostra novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Recurvirostra_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2202208;
}
