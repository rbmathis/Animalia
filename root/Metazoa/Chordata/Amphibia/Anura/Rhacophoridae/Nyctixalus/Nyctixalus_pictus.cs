namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Nyctixalus;

/// <summary>
/// Species: Nyctixalus pictus
/// NCBI TaxId: 126588
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctixalus_pictus : Nyctixalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctixalus pictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctixalus_pictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126588;
}
