using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Limnichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Limnichthys.unclassified_Limnichthys;

/// <summary>
/// Abstract class for unclassified Limnichthys (no rank).
/// NCBI TaxId: 2640423
/// </summary>
public abstract class unclassified_Limnichthys : Limnichthys, Iunclassified_Limnichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Limnichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640423;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Limnichthys";
}
