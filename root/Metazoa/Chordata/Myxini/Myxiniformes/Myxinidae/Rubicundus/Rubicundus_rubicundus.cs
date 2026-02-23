namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Rubicundus;

/// <summary>
/// Species: Rubicundus rubicundus
/// NCBI TaxId: 3360517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rubicundus_rubicundus : Rubicundus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rubicundus rubicundus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rubicundus_rubicundus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3360517;
}
