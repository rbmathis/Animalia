namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

/// <summary>
/// Species: Vulpes sp.
/// NCBI TaxId: 30540
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vulpes_sp : Vulpes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vulpes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vulpes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30540;
}
