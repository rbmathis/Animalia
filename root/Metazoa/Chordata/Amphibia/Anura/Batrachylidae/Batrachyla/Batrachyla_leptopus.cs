namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Batrachyla;

/// <summary>
/// Species: Batrachyla leptopus
/// NCBI TaxId: 215153
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batrachyla_leptopus : Batrachyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batrachyla leptopus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batrachyla_leptopus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 215153;
}
