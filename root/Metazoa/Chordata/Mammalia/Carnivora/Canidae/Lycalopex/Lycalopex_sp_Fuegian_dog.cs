namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycalopex;

/// <summary>
/// Species: Lycalopex sp. Fuegian dog
/// NCBI TaxId: 1303779
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lycalopex_sp_Fuegian_dog : Lycalopex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lycalopex sp. Fuegian dog";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lycalopex_sp_Fuegian_dog";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1303779;
}
