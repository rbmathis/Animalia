namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio sp.
/// NCBI TaxId: 61183
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_sp : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61183;
}
