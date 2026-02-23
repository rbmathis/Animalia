namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophorus;

/// <summary>
/// Species: Cephalophorus rufilatus
/// NCBI TaxId: 129230
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cephalophorus_rufilatus : Cephalophorus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cephalophorus rufilatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cephalophorus_rufilatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129230;
}
