namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos sp.
/// NCBI TaxId: 29061
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_sp : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29061;
}
