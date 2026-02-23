namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctotherium;

/// <summary>
/// Species: Arctotherium sp.
/// NCBI TaxId: 1825730
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arctotherium_sp : Arctotherium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arctotherium sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arctotherium_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1825730;
}
