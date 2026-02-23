namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Branchiostoma;

/// <summary>
/// Species: Branchiostoma sp.
/// NCBI TaxId: 30271
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branchiostoma_sp : Branchiostoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branchiostoma sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branchiostoma_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30271;
}
