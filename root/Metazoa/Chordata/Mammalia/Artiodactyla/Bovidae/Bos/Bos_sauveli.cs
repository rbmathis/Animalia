namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos sauveli
/// NCBI TaxId: 135829
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_sauveli : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos sauveli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_sauveli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 135829;
}
