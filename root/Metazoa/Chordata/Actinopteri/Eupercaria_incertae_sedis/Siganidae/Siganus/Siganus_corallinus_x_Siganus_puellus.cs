namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.Siganus;

/// <summary>
/// Species: Siganus corallinus x Siganus puellus
/// NCBI TaxId: 406537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Siganus_corallinus_x_Siganus_puellus : Siganus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Siganus corallinus x Siganus puellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Siganus_corallinus_x_Siganus_puellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 406537;
}
