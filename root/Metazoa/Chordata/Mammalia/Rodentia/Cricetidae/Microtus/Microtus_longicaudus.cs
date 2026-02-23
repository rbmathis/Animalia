namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus longicaudus
/// NCBI TaxId: 98314
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_longicaudus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus longicaudus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_longicaudus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98314;
}
