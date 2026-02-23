namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Colostethus;

/// <summary>
/// Species: Colostethus inguinalis
/// NCBI TaxId: 384864
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colostethus_inguinalis : Colostethus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colostethus inguinalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colostethus_inguinalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 384864;
}
