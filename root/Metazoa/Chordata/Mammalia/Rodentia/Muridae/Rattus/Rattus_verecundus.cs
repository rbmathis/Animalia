namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus verecundus
/// NCBI TaxId: 472764
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_verecundus : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus verecundus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_verecundus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 472764;
}
