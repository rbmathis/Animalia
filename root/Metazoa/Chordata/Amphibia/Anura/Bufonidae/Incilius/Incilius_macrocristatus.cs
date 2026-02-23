namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Incilius;

/// <summary>
/// Species: Incilius macrocristatus
/// NCBI TaxId: 138083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Incilius_macrocristatus : Incilius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Incilius macrocristatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Incilius_macrocristatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 138083;
}
