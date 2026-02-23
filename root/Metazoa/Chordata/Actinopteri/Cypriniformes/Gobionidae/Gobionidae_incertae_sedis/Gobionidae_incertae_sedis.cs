using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobionidae_incertae_sedis;

/// <summary>
/// Abstract class for Gobionidae incertae sedis (no rank).
/// NCBI TaxId: 2743724
/// </summary>
public abstract class Gobionidae_incertae_sedis : Gobionidae, IGobionidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobionidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743724;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Gobionidae_incertae_sedis";
}
