using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Sufflamen;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Sufflamen.unclassified_Sufflamen;

/// <summary>
/// Abstract class for unclassified Sufflamen (no rank).
/// NCBI TaxId: 2725365
/// </summary>
public abstract class unclassified_Sufflamen : Sufflamen, Iunclassified_Sufflamen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sufflamen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2725365;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sufflamen";
}
