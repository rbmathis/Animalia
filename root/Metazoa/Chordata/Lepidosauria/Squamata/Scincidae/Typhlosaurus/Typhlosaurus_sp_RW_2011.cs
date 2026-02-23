namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Typhlosaurus;

/// <summary>
/// Species: Typhlosaurus sp. RW-2011
/// NCBI TaxId: 1004771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Typhlosaurus_sp_RW_2011 : Typhlosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Typhlosaurus sp. RW-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Typhlosaurus_sp_RW_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1004771;
}
