namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Somniosus;

/// <summary>
/// Species: Somniosus microcephalus
/// NCBI TaxId: 191813
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Somniosus_microcephalus : Somniosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Somniosus microcephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Somniosus_microcephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 191813;
}
