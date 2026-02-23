namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax fuscomarginatus
/// NCBI TaxId: 1033720
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_fuscomarginatus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax fuscomarginatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_fuscomarginatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1033720;
}
