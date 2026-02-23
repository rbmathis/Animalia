namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Gasteropelecus;

/// <summary>
/// Species: Gasteropelecus sp.
/// NCBI TaxId: 42499
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gasteropelecus_sp : Gasteropelecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gasteropelecus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gasteropelecus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42499;
}
