namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Species: Rhipidura tenebrosa
/// NCBI TaxId: 667194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhipidura_tenebrosa : Rhipidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhipidura tenebrosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhipidura_tenebrosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 667194;
}
