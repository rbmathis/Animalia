using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis;

/// <summary>
/// Abstract class for Eupercaria incertae sedis (no rank).
/// NCBI TaxId: 1489923
/// </summary>
public abstract class Eupercaria_incertae_sedis : Actinopteri, IEupercaria_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupercaria incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Eupercaria_incertae_sedis";
}
