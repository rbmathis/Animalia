namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Microspingus;

/// <summary>
/// Species: Microspingus trifasciatus
/// NCBI TaxId: 166077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microspingus_trifasciatus : Microspingus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microspingus trifasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microspingus_trifasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 166077;
}
