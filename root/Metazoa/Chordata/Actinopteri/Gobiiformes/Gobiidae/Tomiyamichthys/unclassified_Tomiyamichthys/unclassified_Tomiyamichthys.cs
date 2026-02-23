using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tomiyamichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tomiyamichthys.unclassified_Tomiyamichthys;

/// <summary>
/// Abstract class for unclassified Tomiyamichthys (no rank).
/// NCBI TaxId: 3076167
/// </summary>
public abstract class unclassified_Tomiyamichthys : Tomiyamichthys, Iunclassified_Tomiyamichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tomiyamichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3076167;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tomiyamichthys";
}
