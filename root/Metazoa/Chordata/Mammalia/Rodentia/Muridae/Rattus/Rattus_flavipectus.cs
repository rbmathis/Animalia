namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus flavipectus
/// NCBI TaxId: 69074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_flavipectus : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus flavipectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_flavipectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69074;
}
