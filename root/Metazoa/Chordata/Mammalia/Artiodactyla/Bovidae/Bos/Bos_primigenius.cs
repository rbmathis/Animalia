namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos primigenius
/// NCBI TaxId: 9909
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_primigenius : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos primigenius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_primigenius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9909;
}
