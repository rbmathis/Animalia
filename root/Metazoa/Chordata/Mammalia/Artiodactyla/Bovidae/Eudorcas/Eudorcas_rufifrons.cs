namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Eudorcas;

/// <summary>
/// Species: Eudorcas rufifrons
/// NCBI TaxId: 69304
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudorcas_rufifrons : Eudorcas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudorcas rufifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudorcas_rufifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69304;
}
