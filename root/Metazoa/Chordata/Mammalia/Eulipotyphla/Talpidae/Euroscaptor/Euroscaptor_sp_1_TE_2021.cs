namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor;

/// <summary>
/// Species: Euroscaptor sp. 1 TE-2021
/// NCBI TaxId: 2835210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euroscaptor_sp_1_TE_2021 : Euroscaptor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euroscaptor sp. 1 TE-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euroscaptor_sp_1_TE_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2835210;
}
