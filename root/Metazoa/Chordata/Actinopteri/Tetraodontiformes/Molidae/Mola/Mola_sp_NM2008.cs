namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Mola;

/// <summary>
/// Species: Mola sp. NM2008
/// NCBI TaxId: 535277
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mola_sp_NM2008 : Mola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mola sp. NM2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mola_sp_NM2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 535277;
}
