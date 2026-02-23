namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Erinaceus;

/// <summary>
/// Species: Erinaceus sp.
/// NCBI TaxId: 61237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erinaceus_sp : Erinaceus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erinaceus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erinaceus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61237;
}
