namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Platysaurus;

/// <summary>
/// Species: Platysaurus sp. SSV-2002
/// NCBI TaxId: 211474
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysaurus_sp_SSV_2002 : Platysaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysaurus sp. SSV-2002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysaurus_sp_SSV_2002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 211474;
}
