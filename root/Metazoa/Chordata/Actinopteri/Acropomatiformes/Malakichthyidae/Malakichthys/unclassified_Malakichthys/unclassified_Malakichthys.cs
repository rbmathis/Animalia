using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Malakichthyidae.Malakichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Malakichthyidae.Malakichthys.unclassified_Malakichthys;

/// <summary>
/// Abstract class for unclassified Malakichthys (no rank).
/// NCBI TaxId: 2619649
/// </summary>
public abstract class unclassified_Malakichthys : Malakichthys, Iunclassified_Malakichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Malakichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619649;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Malakichthys";
}
