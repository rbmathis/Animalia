namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

/// <summary>
/// Species: Hyperolius rubrovermiculatus
/// NCBI TaxId: 1680153
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyperolius_rubrovermiculatus : Hyperolius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyperolius rubrovermiculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyperolius_rubrovermiculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1680153;
}
