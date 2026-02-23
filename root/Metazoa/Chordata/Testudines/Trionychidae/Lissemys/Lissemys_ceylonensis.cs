namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Lissemys;

/// <summary>
/// Species: Lissemys ceylonensis
/// NCBI TaxId: 1853348
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lissemys_ceylonensis : Lissemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lissemys ceylonensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lissemys_ceylonensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1853348;
}
