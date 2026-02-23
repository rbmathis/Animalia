namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadus;

/// <summary>
/// Species: Gadus sp.
/// NCBI TaxId: 8051
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gadus_sp : Gadus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gadus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gadus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8051;
}
