namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Hoplobatrachus;

/// <summary>
/// Species: Hoplobatrachus crassus
/// NCBI TaxId: 129005
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hoplobatrachus_crassus : Hoplobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hoplobatrachus crassus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hoplobatrachus_crassus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129005;
}
