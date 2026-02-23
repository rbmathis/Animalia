using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Teleocichla;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Teleocichla.unclassified_Teleocichla;

/// <summary>
/// Abstract class for unclassified Teleocichla (no rank).
/// NCBI TaxId: 2636789
/// </summary>
public abstract class unclassified_Teleocichla : Teleocichla, Iunclassified_Teleocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Teleocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636789;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Teleocichla";
}
