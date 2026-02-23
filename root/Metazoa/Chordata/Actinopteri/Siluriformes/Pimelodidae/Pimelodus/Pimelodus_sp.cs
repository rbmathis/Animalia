namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelodus;

/// <summary>
/// Species: Pimelodus sp.
/// NCBI TaxId: 42505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pimelodus_sp : Pimelodus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pimelodus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pimelodus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42505;
}
