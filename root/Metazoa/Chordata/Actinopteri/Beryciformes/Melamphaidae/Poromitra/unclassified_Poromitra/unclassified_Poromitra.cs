using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Poromitra;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Poromitra.unclassified_Poromitra;

/// <summary>
/// Abstract class for unclassified Poromitra (no rank).
/// NCBI TaxId: 2634946
/// </summary>
public abstract class unclassified_Poromitra : Poromitra, Iunclassified_Poromitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poromitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634946;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poromitra";
}
