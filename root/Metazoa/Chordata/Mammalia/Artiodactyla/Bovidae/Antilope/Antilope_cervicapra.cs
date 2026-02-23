namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Antilope;

/// <summary>
/// Species: Antilope cervicapra
/// NCBI TaxId: 59525
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Antilope_cervicapra : Antilope
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Antilope cervicapra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Antilope_cervicapra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59525;
}
