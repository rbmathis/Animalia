namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Synbranchus;

/// <summary>
/// Species: Synbranchus marmoratus
/// NCBI TaxId: 181452
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Synbranchus_marmoratus : Synbranchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Synbranchus marmoratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Synbranchus_marmoratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 181452;
}
