namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eothenomys;

/// <summary>
/// Species: Eothenomys melanogaster
/// NCBI TaxId: 82468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eothenomys_melanogaster : Eothenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eothenomys melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eothenomys_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 82468;
}
