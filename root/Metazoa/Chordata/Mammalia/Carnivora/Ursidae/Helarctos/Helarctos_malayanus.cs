namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Helarctos;

/// <summary>
/// Species: Helarctos malayanus
/// NCBI TaxId: 9634
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Helarctos_malayanus : Helarctos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Helarctos malayanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Helarctos_malayanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9634;
}
