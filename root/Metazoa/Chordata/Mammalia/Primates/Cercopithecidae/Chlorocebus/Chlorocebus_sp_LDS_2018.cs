namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus;

/// <summary>
/// Species: Chlorocebus sp. LDS-2018
/// NCBI TaxId: 2282232
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlorocebus_sp_LDS_2018 : Chlorocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlorocebus sp. LDS-2018";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlorocebus_sp_LDS_2018";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2282232;
}
