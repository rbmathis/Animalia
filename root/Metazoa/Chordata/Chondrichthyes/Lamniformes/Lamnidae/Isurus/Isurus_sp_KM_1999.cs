namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Isurus;

/// <summary>
/// Species: Isurus sp. KM-1999
/// NCBI TaxId: 1138768
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Isurus_sp_KM_1999 : Isurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Isurus sp. KM-1999";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Isurus_sp_KM_1999";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1138768;
}
