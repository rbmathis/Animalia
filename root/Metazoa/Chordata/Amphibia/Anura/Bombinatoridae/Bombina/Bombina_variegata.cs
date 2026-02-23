namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina;

/// <summary>
/// Species: Bombina variegata
/// NCBI TaxId: 8348
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bombina_variegata : Bombina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bombina variegata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bombina_variegata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8348;
}
