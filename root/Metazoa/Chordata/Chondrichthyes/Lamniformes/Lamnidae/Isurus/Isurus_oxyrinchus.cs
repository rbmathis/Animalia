namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Isurus;

/// <summary>
/// Species: Isurus oxyrinchus
/// NCBI TaxId: 57983
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Isurus_oxyrinchus : Isurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Isurus oxyrinchus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Isurus_oxyrinchus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57983;
}
