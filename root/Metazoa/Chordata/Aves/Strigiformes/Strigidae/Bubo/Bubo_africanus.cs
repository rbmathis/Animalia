namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo;

/// <summary>
/// Species: Bubo africanus
/// NCBI TaxId: 126801
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubo_africanus : Bubo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubo africanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubo_africanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126801;
}
