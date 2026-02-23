namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllostomus;

/// <summary>
/// Species: Phyllostomus latifolius
/// NCBI TaxId: 999937
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllostomus_latifolius : Phyllostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllostomus latifolius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllostomus_latifolius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 999937;
}
