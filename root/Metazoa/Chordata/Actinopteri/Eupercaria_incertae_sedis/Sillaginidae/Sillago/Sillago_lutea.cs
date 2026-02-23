namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillago;

/// <summary>
/// Species: Sillago lutea
/// NCBI TaxId: 2012950
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sillago_lutea : Sillago
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sillago lutea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sillago_lutea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2012950;
}
