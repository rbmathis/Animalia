namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cnemiornis;

/// <summary>
/// Species: Cnemiornis gracilis
/// NCBI TaxId: 3380701
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cnemiornis_gracilis : Cnemiornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cnemiornis gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cnemiornis_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3380701;
}
