using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Telmatherina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Telmatherina.unclassified_Telmatherina;

/// <summary>
/// Abstract class for unclassified Telmatherina (no rank).
/// NCBI TaxId: 2641878
/// </summary>
public abstract class unclassified_Telmatherina : Telmatherina, Iunclassified_Telmatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Telmatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641878;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Telmatherina";
}
