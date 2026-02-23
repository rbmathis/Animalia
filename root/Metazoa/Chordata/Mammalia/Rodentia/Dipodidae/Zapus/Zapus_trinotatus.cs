namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Zapus;

/// <summary>
/// Species: Zapus trinotatus
/// NCBI TaxId: 98661
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zapus_trinotatus : Zapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zapus trinotatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zapus_trinotatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98661;
}
