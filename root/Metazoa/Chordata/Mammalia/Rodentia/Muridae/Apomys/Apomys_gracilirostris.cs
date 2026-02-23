namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apomys;

/// <summary>
/// Species: Apomys gracilirostris
/// NCBI TaxId: 238003
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apomys_gracilirostris : Apomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apomys gracilirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apomys_gracilirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 238003;
}
