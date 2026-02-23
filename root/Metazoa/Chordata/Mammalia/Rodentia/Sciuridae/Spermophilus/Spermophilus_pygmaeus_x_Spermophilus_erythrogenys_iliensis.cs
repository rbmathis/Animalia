namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

/// <summary>
/// Species: Spermophilus pygmaeus x Spermophilus erythrogenys iliensis
/// NCBI TaxId: 2008353
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spermophilus_pygmaeus_x_Spermophilus_erythrogenys_iliensis : Spermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spermophilus pygmaeus x Spermophilus erythrogenys iliensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spermophilus_pygmaeus_x_Spermophilus_erythrogenys_iliensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2008353;
}
