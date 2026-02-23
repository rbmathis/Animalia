namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax argyreornatus
/// NCBI TaxId: 1903091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_argyreornatus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax argyreornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_argyreornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1903091;
}
