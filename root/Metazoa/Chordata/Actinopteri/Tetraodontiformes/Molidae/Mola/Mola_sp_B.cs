namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Mola;

/// <summary>
/// Species: Mola sp. B
/// NCBI TaxId: 2012986
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mola_sp_B : Mola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mola sp. B";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mola_sp_B";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2012986;
}
