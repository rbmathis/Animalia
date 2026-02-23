using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Gyrinomimus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Gyrinomimus.unclassified_Gyrinomimus;

/// <summary>
/// Abstract class for unclassified Gyrinomimus (no rank).
/// NCBI TaxId: 2618127
/// </summary>
public abstract class unclassified_Gyrinomimus : Gyrinomimus, Iunclassified_Gyrinomimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gyrinomimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618127;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gyrinomimus";
}
