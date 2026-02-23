namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllostomus;

/// <summary>
/// Species: Phyllostomus hastatus
/// NCBI TaxId: 9423
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllostomus_hastatus : Phyllostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllostomus hastatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllostomus_hastatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9423;
}
