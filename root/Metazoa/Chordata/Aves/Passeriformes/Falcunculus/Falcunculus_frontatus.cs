namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Falcunculus;

/// <summary>
/// Species: Falcunculus frontatus
/// NCBI TaxId: 254539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falcunculus_frontatus : Falcunculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falcunculus frontatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falcunculus_frontatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 254539;
}
