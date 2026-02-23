namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Mustelus;

/// <summary>
/// Species: Mustelus mustelus
/// NCBI TaxId: 112230
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustelus_mustelus : Mustelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustelus mustelus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustelus_mustelus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 112230;
}
