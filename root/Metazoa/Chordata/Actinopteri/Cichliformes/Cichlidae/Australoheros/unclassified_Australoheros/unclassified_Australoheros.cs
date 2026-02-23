using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Australoheros;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Australoheros.unclassified_Australoheros;

/// <summary>
/// Abstract class for unclassified Australoheros (no rank).
/// NCBI TaxId: 2626802
/// </summary>
public abstract class unclassified_Australoheros : Australoheros, Iunclassified_Australoheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Australoheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626802;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Australoheros";
}
