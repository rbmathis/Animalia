namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygosoma;

/// <summary>
/// Species: Lygosoma corpulentum
/// NCBI TaxId: 2571092
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygosoma_corpulentum : Lygosoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygosoma corpulentum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygosoma_corpulentum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2571092;
}
