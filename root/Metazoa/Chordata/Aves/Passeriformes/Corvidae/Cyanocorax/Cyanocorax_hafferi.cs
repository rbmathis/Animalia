namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocorax;

/// <summary>
/// Species: Cyanocorax hafferi
/// NCBI TaxId: 1465722
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocorax_hafferi : Cyanocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocorax hafferi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocorax_hafferi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1465722;
}
