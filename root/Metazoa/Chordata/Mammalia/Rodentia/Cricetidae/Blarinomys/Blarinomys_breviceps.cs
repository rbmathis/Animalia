namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Blarinomys;

/// <summary>
/// Species: Blarinomys breviceps
/// NCBI TaxId: 89115
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Blarinomys_breviceps : Blarinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Blarinomys breviceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Blarinomys_breviceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89115;
}
