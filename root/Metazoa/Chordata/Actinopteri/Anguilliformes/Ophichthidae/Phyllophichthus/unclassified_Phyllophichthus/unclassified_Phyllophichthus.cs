using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Phyllophichthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Phyllophichthus.unclassified_Phyllophichthus;

/// <summary>
/// Abstract class for unclassified Phyllophichthus (no rank).
/// NCBI TaxId: 3144967
/// </summary>
public abstract class unclassified_Phyllophichthus : Phyllophichthus, Iunclassified_Phyllophichthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllophichthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3144967;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllophichthus";
}
