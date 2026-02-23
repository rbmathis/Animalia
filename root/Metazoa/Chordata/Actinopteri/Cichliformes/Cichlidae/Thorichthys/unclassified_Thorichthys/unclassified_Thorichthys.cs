using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thorichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thorichthys.unclassified_Thorichthys;

/// <summary>
/// Abstract class for unclassified Thorichthys (no rank).
/// NCBI TaxId: 2648392
/// </summary>
public abstract class unclassified_Thorichthys : Thorichthys, Iunclassified_Thorichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thorichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thorichthys";
}
