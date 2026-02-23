namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Cobitis;

/// <summary>
/// Species: Cobitis sp. Marmara
/// NCBI TaxId: 3447590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cobitis_sp_Marmara : Cobitis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cobitis sp. Marmara";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cobitis_sp_Marmara";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3447590;
}
