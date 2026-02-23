namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser serrirostris
/// NCBI TaxId: 2606890
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_serrirostris : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser serrirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_serrirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2606890;
}
