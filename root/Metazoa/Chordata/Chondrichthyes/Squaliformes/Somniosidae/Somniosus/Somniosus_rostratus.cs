namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Somniosus;

/// <summary>
/// Species: Somniosus rostratus
/// NCBI TaxId: 263719
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Somniosus_rostratus : Somniosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Somniosus rostratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Somniosus_rostratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 263719;
}
