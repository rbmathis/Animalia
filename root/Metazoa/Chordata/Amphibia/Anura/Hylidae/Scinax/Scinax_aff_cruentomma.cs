namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax aff. cruentomma
/// NCBI TaxId: 3446475
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_aff_cruentomma : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax aff. cruentomma";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_aff_cruentomma";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3446475;
}
