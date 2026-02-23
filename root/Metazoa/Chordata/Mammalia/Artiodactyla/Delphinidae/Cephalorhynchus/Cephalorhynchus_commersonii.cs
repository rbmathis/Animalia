namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Cephalorhynchus;

/// <summary>
/// Species: Cephalorhynchus commersonii
/// NCBI TaxId: 103582
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cephalorhynchus_commersonii : Cephalorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cephalorhynchus commersonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cephalorhynchus_commersonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103582;
}
