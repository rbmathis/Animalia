namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callimico;

/// <summary>
/// Species: Callimico sp.
/// NCBI TaxId: 1758239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callimico_sp : Callimico
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callimico sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callimico_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1758239;
}
