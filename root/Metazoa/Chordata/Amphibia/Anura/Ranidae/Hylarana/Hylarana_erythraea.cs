namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

/// <summary>
/// Species: Hylarana erythraea
/// NCBI TaxId: 110077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylarana_erythraea : Hylarana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylarana erythraea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylarana_erythraea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 110077;
}
