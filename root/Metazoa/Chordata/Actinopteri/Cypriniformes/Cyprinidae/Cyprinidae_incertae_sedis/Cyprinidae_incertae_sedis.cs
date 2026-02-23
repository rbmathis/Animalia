using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis;

/// <summary>
/// Abstract class for Cyprinidae incertae sedis (no rank).
/// NCBI TaxId: 2743708
/// </summary>
public abstract class Cyprinidae_incertae_sedis : Cyprinidae, ICyprinidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743708;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cyprinidae_incertae_sedis";
}
