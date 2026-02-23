namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor sp. Chumacera
/// NCBI TaxId: 3345335
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_sp_Chumacera : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor sp. Chumacera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_sp_Chumacera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3345335;
}
