using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Tanichthyidae.Tanichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Tanichthyidae.Tanichthys.unclassified_Tanichthys;

/// <summary>
/// Abstract class for unclassified Tanichthys (no rank).
/// NCBI TaxId: 2944555
/// </summary>
public abstract class unclassified_Tanichthys : Tanichthys, Iunclassified_Tanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2944555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tanichthys";
}
