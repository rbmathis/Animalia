namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Sitta;

/// <summary>
/// Species: Sitta pygmaea
/// NCBI TaxId: 50256
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sitta_pygmaea : Sitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sitta pygmaea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sitta_pygmaea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50256;
}
