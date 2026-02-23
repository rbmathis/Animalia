namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Species: Tamias striatus
/// NCBI TaxId: 45474
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamias_striatus : Tamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamias striatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamias_striatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45474;
}
