namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Helodermatidae.Heloderma;

/// <summary>
/// Species: Heloderma sp.
/// NCBI TaxId: 8553
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heloderma_sp : Heloderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heloderma sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heloderma_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8553;
}
