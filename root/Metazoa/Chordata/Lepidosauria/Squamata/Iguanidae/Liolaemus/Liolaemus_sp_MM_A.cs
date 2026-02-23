namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Liolaemus;

/// <summary>
/// Species: Liolaemus sp. MM-A
/// NCBI TaxId: 221513
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Liolaemus_sp_MM_A : Liolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Liolaemus sp. MM-A";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Liolaemus_sp_MM_A";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221513;
}
