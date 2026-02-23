namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor punctariolus
/// NCBI TaxId: 356181
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_punctariolus : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor punctariolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_punctariolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 356181;
}
