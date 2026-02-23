namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vernaya;

/// <summary>
/// Species: Vernaya fulva
/// NCBI TaxId: 2073147
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vernaya_fulva : Vernaya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vernaya fulva";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vernaya_fulva";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2073147;
}
