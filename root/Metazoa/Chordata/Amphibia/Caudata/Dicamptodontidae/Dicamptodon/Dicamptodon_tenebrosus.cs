namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Dicamptodontidae.Dicamptodon;

/// <summary>
/// Species: Dicamptodon tenebrosus
/// NCBI TaxId: 94176
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dicamptodon_tenebrosus : Dicamptodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dicamptodon tenebrosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dicamptodon_tenebrosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94176;
}
