namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hemiramphus;

/// <summary>
/// Species: Hemiramphus sp.
/// NCBI TaxId: 94223
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemiramphus_sp : Hemiramphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemiramphus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemiramphus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94223;
}
