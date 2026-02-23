namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

/// <summary>
/// Species: Cercopithecidae gen. sp.
/// NCBI TaxId: 9576
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercopithecidae_gen_sp : Cercopithecidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercopithecidae gen. sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercopithecidae_gen_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9576;
}
