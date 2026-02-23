namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Eudorcas;

/// <summary>
/// Species: Eudorcas thomsonii
/// NCBI TaxId: 69308
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudorcas_thomsonii : Eudorcas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudorcas thomsonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudorcas_thomsonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69308;
}
