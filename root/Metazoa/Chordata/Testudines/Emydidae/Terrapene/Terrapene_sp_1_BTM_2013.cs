namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Species: Terrapene sp. 1 BTM-2013
/// NCBI TaxId: 1335719
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Terrapene_sp_1_BTM_2013 : Terrapene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Terrapene sp. 1 BTM-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Terrapene_sp_1_BTM_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1335719;
}
