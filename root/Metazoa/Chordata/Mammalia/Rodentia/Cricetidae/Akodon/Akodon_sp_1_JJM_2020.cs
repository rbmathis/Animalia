namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon;

/// <summary>
/// Species: Akodon sp. 1 JJM-2020
/// NCBI TaxId: 2772441
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Akodon_sp_1_JJM_2020 : Akodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Akodon sp. 1 JJM-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Akodon_sp_1_JJM_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2772441;
}
