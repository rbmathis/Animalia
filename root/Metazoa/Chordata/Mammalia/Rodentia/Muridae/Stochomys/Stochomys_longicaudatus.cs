namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stochomys;

/// <summary>
/// Species: Stochomys longicaudatus
/// NCBI TaxId: 34856
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stochomys_longicaudatus : Stochomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stochomys longicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stochomys_longicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34856;
}
