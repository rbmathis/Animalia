namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lytorhynchus;

/// <summary>
/// Species: Lytorhynchus paradoxus
/// NCBI TaxId: 2829528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lytorhynchus_paradoxus : Lytorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lytorhynchus paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lytorhynchus_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2829528;
}
