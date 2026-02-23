namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos frontalis
/// NCBI TaxId: 30520
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_frontalis : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos frontalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_frontalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30520;
}
