namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tarsomys;

/// <summary>
/// Species: Tarsomys echinatus
/// NCBI TaxId: 3002844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarsomys_echinatus : Tarsomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarsomys echinatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarsomys_echinatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3002844;
}
