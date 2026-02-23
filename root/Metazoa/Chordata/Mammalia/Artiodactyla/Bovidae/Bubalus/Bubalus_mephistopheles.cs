namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bubalus;

/// <summary>
/// Species: Bubalus mephistopheles
/// NCBI TaxId: 3457542
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubalus_mephistopheles : Bubalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubalus mephistopheles";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubalus_mephistopheles";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3457542;
}
