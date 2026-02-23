using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichla;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichla.unclassified_Cichla;

/// <summary>
/// Abstract class for unclassified Cichla (no rank).
/// NCBI TaxId: 2645274
/// </summary>
public abstract class unclassified_Cichla : Cichla, Iunclassified_Cichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645274;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cichla";
}
