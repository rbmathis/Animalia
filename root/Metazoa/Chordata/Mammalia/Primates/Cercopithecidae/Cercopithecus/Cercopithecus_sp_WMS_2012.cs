namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercopithecus;

/// <summary>
/// Species: Cercopithecus sp. WMS-2012
/// NCBI TaxId: 1144881
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercopithecus_sp_WMS_2012 : Cercopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercopithecus sp. WMS-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercopithecus_sp_WMS_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1144881;
}
