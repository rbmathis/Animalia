namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Typhlosaurus;

/// <summary>
/// Species: Typhlosaurus sp. MCB-2011
/// NCBI TaxId: 946267
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Typhlosaurus_sp_MCB_2011 : Typhlosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Typhlosaurus sp. MCB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Typhlosaurus_sp_MCB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 946267;
}
