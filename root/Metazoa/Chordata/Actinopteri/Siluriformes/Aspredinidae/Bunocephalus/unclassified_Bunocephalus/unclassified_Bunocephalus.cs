using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Bunocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Bunocephalus.unclassified_Bunocephalus;

/// <summary>
/// Abstract class for unclassified Bunocephalus (no rank).
/// NCBI TaxId: 2623909
/// </summary>
public abstract class unclassified_Bunocephalus : Bunocephalus, Iunclassified_Bunocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bunocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623909;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bunocephalus";
}
