using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Protocobitis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Protocobitis.unclassified_Protocobitis;

/// <summary>
/// Abstract class for unclassified Protocobitis (no rank).
/// NCBI TaxId: 3111787
/// </summary>
public abstract class unclassified_Protocobitis : Protocobitis, Iunclassified_Protocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Protocobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3111787;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Protocobitis";
}
