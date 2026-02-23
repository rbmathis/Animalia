namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus;

/// <summary>
/// Species: Chlorocebus sp. TH-2013
/// NCBI TaxId: 1284216
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlorocebus_sp_TH_2013 : Chlorocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlorocebus sp. TH-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlorocebus_sp_TH_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1284216;
}
