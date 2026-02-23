namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Myornis;

/// <summary>
/// Species: Myornis senilis
/// NCBI TaxId: 42820
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myornis_senilis : Myornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myornis senilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myornis_senilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42820;
}
