using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Pyrolycus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Pyrolycus.unclassified_Pyrolycus;

/// <summary>
/// Abstract class for unclassified Pyrolycus (no rank).
/// NCBI TaxId: 2972964
/// </summary>
public abstract class unclassified_Pyrolycus : Pyrolycus, Iunclassified_Pyrolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2972964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrolycus";
}
