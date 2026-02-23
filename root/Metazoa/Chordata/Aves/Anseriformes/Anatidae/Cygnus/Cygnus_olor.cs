namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cygnus;

/// <summary>
/// Species: Cygnus olor
/// NCBI TaxId: 8869
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cygnus_olor : Cygnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cygnus olor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cygnus_olor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8869;
}
