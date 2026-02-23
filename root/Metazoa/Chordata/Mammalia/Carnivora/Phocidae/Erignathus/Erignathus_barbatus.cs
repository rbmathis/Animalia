namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Erignathus;

/// <summary>
/// Species: Erignathus barbatus
/// NCBI TaxId: 39304
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erignathus_barbatus : Erignathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erignathus barbatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erignathus_barbatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39304;
}
