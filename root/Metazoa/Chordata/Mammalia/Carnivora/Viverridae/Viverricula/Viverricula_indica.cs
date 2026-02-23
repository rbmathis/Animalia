namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Viverricula;

/// <summary>
/// Species: Viverricula indica
/// NCBI TaxId: 94196
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Viverricula_indica : Viverricula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Viverricula indica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Viverricula_indica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94196;
}
