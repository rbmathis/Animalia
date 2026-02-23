namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Gonatodes;

/// <summary>
/// Species: Gonatodes sp. WES-2012
/// NCBI TaxId: 1234521
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gonatodes_sp_WES_2012 : Gonatodes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gonatodes sp. WES-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gonatodes_sp_WES_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234521;
}
