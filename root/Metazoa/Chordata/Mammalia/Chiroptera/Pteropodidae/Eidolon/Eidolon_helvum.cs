namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Eidolon;

/// <summary>
/// Species: Eidolon helvum
/// NCBI TaxId: 77214
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eidolon_helvum : Eidolon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eidolon helvum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eidolon_helvum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 77214;
}
