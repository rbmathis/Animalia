namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Colostethus;

/// <summary>
/// Species: Colostethus sp. Magdalena
/// NCBI TaxId: 384879
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colostethus_sp_Magdalena : Colostethus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colostethus sp. Magdalena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colostethus_sp_Magdalena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 384879;
}
