namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Mustelus;

/// <summary>
/// Species: Mustelus punctulatus
/// NCBI TaxId: 112233
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustelus_punctulatus : Mustelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustelus punctulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustelus_punctulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 112233;
}
