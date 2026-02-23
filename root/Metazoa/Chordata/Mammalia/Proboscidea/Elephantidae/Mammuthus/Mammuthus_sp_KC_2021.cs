namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

/// <summary>
/// Species: Mammuthus sp. KC-2021
/// NCBI TaxId: 2801150
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammuthus_sp_KC_2021 : Mammuthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammuthus sp. KC-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammuthus_sp_KC_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2801150;
}
