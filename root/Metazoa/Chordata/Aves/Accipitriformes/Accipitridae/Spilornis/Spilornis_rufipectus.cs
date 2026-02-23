namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Spilornis;

/// <summary>
/// Species: Spilornis rufipectus
/// NCBI TaxId: 321083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spilornis_rufipectus : Spilornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spilornis rufipectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spilornis_rufipectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 321083;
}
