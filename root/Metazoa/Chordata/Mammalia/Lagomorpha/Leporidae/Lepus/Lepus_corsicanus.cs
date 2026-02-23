namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus corsicanus
/// NCBI TaxId: 100181
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_corsicanus : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus corsicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_corsicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100181;
}
