using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Crenicichla;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Crenicichla.unclassified_Crenicichla;

/// <summary>
/// Abstract class for unclassified Crenicichla (no rank).
/// NCBI TaxId: 2634349
/// </summary>
public abstract class unclassified_Crenicichla : Crenicichla, Iunclassified_Crenicichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crenicichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634349;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crenicichla";
}
