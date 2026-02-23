namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bubalus;

/// <summary>
/// Species: Bubalus sp.
/// NCBI TaxId: 85875
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubalus_sp : Bubalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubalus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubalus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85875;
}
