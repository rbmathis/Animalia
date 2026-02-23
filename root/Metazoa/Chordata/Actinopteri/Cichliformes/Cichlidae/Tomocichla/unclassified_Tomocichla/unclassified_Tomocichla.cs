using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tomocichla;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tomocichla.unclassified_Tomocichla;

/// <summary>
/// Abstract class for unclassified Tomocichla (no rank).
/// NCBI TaxId: 2631609
/// </summary>
public abstract class unclassified_Tomocichla : Tomocichla, Iunclassified_Tomocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tomocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631609;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tomocichla";
}
