namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Dolichotis;

/// <summary>
/// Species: Dolichotis patagonum
/// NCBI TaxId: 29091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dolichotis_patagonum : Dolichotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dolichotis patagonum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dolichotis_patagonum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29091;
}
