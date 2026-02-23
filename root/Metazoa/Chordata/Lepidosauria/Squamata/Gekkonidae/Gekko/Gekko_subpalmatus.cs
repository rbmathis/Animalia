namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko subpalmatus
/// NCBI TaxId: 515999
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_subpalmatus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko subpalmatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_subpalmatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 515999;
}
