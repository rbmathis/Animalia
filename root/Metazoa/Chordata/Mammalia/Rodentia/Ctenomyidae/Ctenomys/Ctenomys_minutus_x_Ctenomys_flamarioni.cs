namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Ctenomys;

/// <summary>
/// Species: Ctenomys minutus x Ctenomys flamarioni
/// NCBI TaxId: 2604415
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenomys_minutus_x_Ctenomys_flamarioni : Ctenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenomys minutus x Ctenomys flamarioni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenomys_minutus_x_Ctenomys_flamarioni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2604415;
}
