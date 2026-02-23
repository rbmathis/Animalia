namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Hoplobatrachus;

/// <summary>
/// Species: Hoplobatrachus chinensis x Hoplobatrachus rugulosus
/// NCBI TaxId: 2547344
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hoplobatrachus_chinensis_x_Hoplobatrachus_rugulosus : Hoplobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hoplobatrachus chinensis x Hoplobatrachus rugulosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hoplobatrachus_chinensis_x_Hoplobatrachus_rugulosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2547344;
}
