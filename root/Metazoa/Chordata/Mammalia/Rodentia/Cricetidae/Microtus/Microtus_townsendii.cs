namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus townsendii
/// NCBI TaxId: 111841
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_townsendii : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus townsendii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_townsendii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111841;
}
