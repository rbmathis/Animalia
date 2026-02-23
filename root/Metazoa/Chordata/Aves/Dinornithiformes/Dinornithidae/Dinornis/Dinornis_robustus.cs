namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae.Dinornis;

/// <summary>
/// Species: Dinornis robustus
/// NCBI TaxId: 314500
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dinornis_robustus : Dinornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dinornis robustus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dinornis_robustus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 314500;
}
