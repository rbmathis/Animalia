namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillus;

/// <summary>
/// Species: Gerbillus sp.
/// NCBI TaxId: 10187
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbillus_sp : Gerbillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbillus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbillus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10187;
}
