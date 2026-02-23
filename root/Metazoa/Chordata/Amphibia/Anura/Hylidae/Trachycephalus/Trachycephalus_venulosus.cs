namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus;

/// <summary>
/// Species: Trachycephalus venulosus
/// NCBI TaxId: 213803
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachycephalus_venulosus : Trachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachycephalus venulosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachycephalus_venulosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213803;
}
