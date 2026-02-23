namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax quinquefasciatus
/// NCBI TaxId: 699832
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_quinquefasciatus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax quinquefasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_quinquefasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 699832;
}
