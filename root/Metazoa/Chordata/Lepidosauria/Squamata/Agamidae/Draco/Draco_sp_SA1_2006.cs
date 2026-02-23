namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco sp. SA1-2006
/// NCBI TaxId: 392779
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_sp_SA1_2006 : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco sp. SA1-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_sp_SA1_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 392779;
}
