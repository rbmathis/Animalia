namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scelotes;

/// <summary>
/// Species: Scelotes mossambicus
/// NCBI TaxId: 3148604
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scelotes_mossambicus : Scelotes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scelotes mossambicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scelotes_mossambicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148604;
}
