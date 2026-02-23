namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhabdornithidae.Rhabdornis;

/// <summary>
/// Species: Rhabdornis inornatus
/// NCBI TaxId: 237438
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhabdornis_inornatus : Rhabdornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhabdornis inornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhabdornis_inornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 237438;
}
