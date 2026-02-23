namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina;

/// <summary>
/// Species: Bombina pachypus
/// NCBI TaxId: 260370
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bombina_pachypus : Bombina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bombina pachypus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bombina_pachypus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260370;
}
