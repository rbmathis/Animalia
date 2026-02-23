namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lontra;

/// <summary>
/// Species: Lontra longicaudis
/// NCBI TaxId: 71113
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lontra_longicaudis : Lontra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lontra longicaudis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lontra_longicaudis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 71113;
}
