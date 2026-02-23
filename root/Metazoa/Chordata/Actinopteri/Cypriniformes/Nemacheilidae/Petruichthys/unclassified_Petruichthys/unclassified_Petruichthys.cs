using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Petruichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Petruichthys.unclassified_Petruichthys;

/// <summary>
/// Abstract class for unclassified Petruichthys (no rank).
/// NCBI TaxId: 2866153
/// </summary>
public abstract class unclassified_Petruichthys : Petruichthys, Iunclassified_Petruichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petruichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2866153;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petruichthys";
}
