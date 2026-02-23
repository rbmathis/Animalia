namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ctenotus;

/// <summary>
/// Species: Ctenotus rufescens
/// NCBI TaxId: 480775
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenotus_rufescens : Ctenotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenotus rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenotus_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 480775;
}
