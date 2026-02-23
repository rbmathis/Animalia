namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Lonchura;

/// <summary>
/// Species: Lonchura leucosticta
/// NCBI TaxId: 2029068
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lonchura_leucosticta : Lonchura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lonchura leucosticta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lonchura_leucosticta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2029068;
}
