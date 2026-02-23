namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus azarai
/// NCBI TaxId: 30591
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_azarai : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus azarai";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_azarai";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30591;
}
