namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Macropus;

/// <summary>
/// Species: Macropus sp.
/// NCBI TaxId: 9322
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macropus_sp : Macropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macropus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macropus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9322;
}
