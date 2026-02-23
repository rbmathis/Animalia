namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Caiman;

/// <summary>
/// Species: Caiman latirostris
/// NCBI TaxId: 190476
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caiman_latirostris : Caiman
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caiman latirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caiman_latirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190476;
}
