namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae;

/// <summary>
/// Species: Elephantidae gen. sp.
/// NCBI TaxId: 9781
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elephantidae_gen_sp : Elephantidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elephantidae gen. sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elephantidae_gen_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9781;
}
