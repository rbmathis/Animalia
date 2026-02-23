namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus pinetorum
/// NCBI TaxId: 111839
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_pinetorum : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus pinetorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_pinetorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111839;
}
