namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser sp. CAS-2009
/// NCBI TaxId: 654604
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_sp_CAS_2009 : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser sp. CAS-2009";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_sp_CAS_2009";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 654604;
}
