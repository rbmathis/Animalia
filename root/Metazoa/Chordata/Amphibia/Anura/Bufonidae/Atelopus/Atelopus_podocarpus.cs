namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus;

/// <summary>
/// Species: Atelopus podocarpus
/// NCBI TaxId: 925726
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atelopus_podocarpus : Atelopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atelopus podocarpus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atelopus_podocarpus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 925726;
}
