namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cygnus;

/// <summary>
/// Species: Cygnus melancoryphus
/// NCBI TaxId: 41691
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cygnus_melancoryphus : Cygnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cygnus melancoryphus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cygnus_melancoryphus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 41691;
}
