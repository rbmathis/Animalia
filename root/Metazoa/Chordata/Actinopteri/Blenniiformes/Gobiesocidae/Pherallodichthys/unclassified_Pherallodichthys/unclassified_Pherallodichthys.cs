using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodichthys.unclassified_Pherallodichthys;

/// <summary>
/// Abstract class for unclassified Pherallodichthys (no rank).
/// NCBI TaxId: 2740791
/// </summary>
public abstract class unclassified_Pherallodichthys : Pherallodichthys, Iunclassified_Pherallodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pherallodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740791;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pherallodichthys";
}
