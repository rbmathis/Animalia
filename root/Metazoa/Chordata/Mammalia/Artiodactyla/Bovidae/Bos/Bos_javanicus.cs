namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos javanicus
/// NCBI TaxId: 9906
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_javanicus : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos javanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_javanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9906;
}
