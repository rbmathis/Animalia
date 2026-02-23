namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Species: Marmota himalayana
/// NCBI TaxId: 93163
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmota_himalayana : Marmota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmota himalayana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmota_himalayana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 93163;
}
