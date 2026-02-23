namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ischnohyla;

/// <summary>
/// Species: Ischnohyla gracilis
/// NCBI TaxId: 3681047
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ischnohyla_gracilis : Ischnohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ischnohyla gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ischnohyla_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681047;
}
