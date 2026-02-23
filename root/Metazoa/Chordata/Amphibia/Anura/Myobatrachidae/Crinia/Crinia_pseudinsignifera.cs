namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Crinia;

/// <summary>
/// Species: Crinia pseudinsignifera
/// NCBI TaxId: 1221127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crinia_pseudinsignifera : Crinia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crinia pseudinsignifera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crinia_pseudinsignifera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1221127;
}
