namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Incilius;

/// <summary>
/// Species: Incilius melanochlorus
/// NCBI TaxId: 302546
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Incilius_melanochlorus : Incilius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Incilius melanochlorus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Incilius_melanochlorus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302546;
}
