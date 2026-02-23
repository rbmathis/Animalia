namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Salamandra;

/// <summary>
/// Species: Salamandra infraimmaculata
/// NCBI TaxId: 156860
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salamandra_infraimmaculata : Salamandra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salamandra infraimmaculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salamandra_infraimmaculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 156860;
}
