namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax nasicus A
/// NCBI TaxId: 1097607
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_nasicus_A : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax nasicus A";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_nasicus_A";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1097607;
}
