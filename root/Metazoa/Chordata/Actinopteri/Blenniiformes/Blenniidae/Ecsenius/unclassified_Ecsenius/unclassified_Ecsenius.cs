using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ecsenius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ecsenius.unclassified_Ecsenius;

/// <summary>
/// Abstract class for unclassified Ecsenius (no rank).
/// NCBI TaxId: 2620626
/// </summary>
public abstract class unclassified_Ecsenius : Ecsenius, Iunclassified_Ecsenius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ecsenius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ecsenius";
}
