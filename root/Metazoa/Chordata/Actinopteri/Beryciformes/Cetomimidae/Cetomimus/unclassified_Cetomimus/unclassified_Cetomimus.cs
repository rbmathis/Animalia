using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetomimus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetomimus.unclassified_Cetomimus;

/// <summary>
/// Abstract class for unclassified Cetomimus (no rank).
/// NCBI TaxId: 2641956
/// </summary>
public abstract class unclassified_Cetomimus : Cetomimus, Iunclassified_Cetomimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetomimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641956;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetomimus";
}
