namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Cynomys;

/// <summary>
/// Species: Cynomys mexicanus
/// NCBI TaxId: 99826
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cynomys_mexicanus : Cynomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cynomys mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cynomys_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99826;
}
