using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Oreichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Oreichthys.unclassified_Oreichthys;

/// <summary>
/// Abstract class for unclassified Oreichthys (no rank).
/// NCBI TaxId: 2629936
/// </summary>
public abstract class unclassified_Oreichthys : Oreichthys, Iunclassified_Oreichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreichthys";
}
