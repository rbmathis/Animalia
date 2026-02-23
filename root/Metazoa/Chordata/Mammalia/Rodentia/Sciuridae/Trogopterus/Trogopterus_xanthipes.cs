namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Trogopterus;

/// <summary>
/// Species: Trogopterus xanthipes
/// NCBI TaxId: 226819
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trogopterus_xanthipes : Trogopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trogopterus xanthipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trogopterus_xanthipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226819;
}
