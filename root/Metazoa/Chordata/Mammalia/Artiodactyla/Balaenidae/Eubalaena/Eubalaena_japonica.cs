namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Eubalaena;

/// <summary>
/// Species: Eubalaena japonica
/// NCBI TaxId: 302098
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eubalaena_japonica : Eubalaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eubalaena japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eubalaena_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302098;
}
