namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas georgica
/// NCBI TaxId: 75847
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_georgica : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas georgica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_georgica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75847;
}
