namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

/// <summary>
/// Species: Spermophilus pygmaeus x Spermophilus erythrogenys
/// NCBI TaxId: 2008352
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spermophilus_pygmaeus_x_Spermophilus_erythrogenys : Spermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spermophilus pygmaeus x Spermophilus erythrogenys";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spermophilus_pygmaeus_x_Spermophilus_erythrogenys";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2008352;
}
