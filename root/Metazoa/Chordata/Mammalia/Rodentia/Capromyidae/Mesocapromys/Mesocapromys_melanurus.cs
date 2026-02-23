namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Mesocapromys;

/// <summary>
/// Species: Mesocapromys melanurus
/// NCBI TaxId: 1567511
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesocapromys_melanurus : Mesocapromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesocapromys melanurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesocapromys_melanurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1567511;
}
