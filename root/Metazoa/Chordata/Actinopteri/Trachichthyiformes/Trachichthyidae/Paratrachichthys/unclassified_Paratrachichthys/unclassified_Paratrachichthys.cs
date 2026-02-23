using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Paratrachichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Paratrachichthys.unclassified_Paratrachichthys;

/// <summary>
/// Abstract class for unclassified Paratrachichthys (no rank).
/// NCBI TaxId: 2626744
/// </summary>
public abstract class unclassified_Paratrachichthys : Paratrachichthys, Iunclassified_Paratrachichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paratrachichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626744;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paratrachichthys";
}
