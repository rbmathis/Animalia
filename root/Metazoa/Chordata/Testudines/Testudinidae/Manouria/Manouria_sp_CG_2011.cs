namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria;

/// <summary>
/// Species: Manouria sp. CG-2011
/// NCBI TaxId: 1053018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manouria_sp_CG_2011 : Manouria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manouria sp. CG-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manouria_sp_CG_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1053018;
}
