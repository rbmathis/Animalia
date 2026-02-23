namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Apus;

/// <summary>
/// Species: Apus unicolor
/// NCBI TaxId: 1160812
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apus_unicolor : Apus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apus unicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apus_unicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1160812;
}
