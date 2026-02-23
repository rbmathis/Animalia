namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Monticola;

/// <summary>
/// Species: Monticola erythronotus
/// NCBI TaxId: 140054
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monticola_erythronotus : Monticola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monticola erythronotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monticola_erythronotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 140054;
}
