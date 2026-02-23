namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus sp. LC-2012
/// NCBI TaxId: 1230482
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_sp_LC_2012 : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus sp. LC-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_sp_LC_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1230482;
}
