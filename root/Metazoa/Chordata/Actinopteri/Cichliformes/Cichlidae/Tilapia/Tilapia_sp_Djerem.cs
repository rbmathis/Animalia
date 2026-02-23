namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

/// <summary>
/// Species: Tilapia sp. Djerem'
/// NCBI TaxId: 1652537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tilapia_sp_Djerem : Tilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tilapia sp. Djerem'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tilapia_sp_Djerem";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1652537;
}
