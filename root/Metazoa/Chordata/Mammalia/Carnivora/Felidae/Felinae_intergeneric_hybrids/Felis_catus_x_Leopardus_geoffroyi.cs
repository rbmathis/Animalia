namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felinae_intergeneric_hybrids;

/// <summary>
/// Species: Felis catus x Leopardus geoffroyi
/// NCBI TaxId: 2796247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_catus_x_Leopardus_geoffroyi : Felinae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis catus x Leopardus geoffroyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_catus_x_Leopardus_geoffroyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2796247;
}
