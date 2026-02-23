using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Cobitis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Cobitis.unclassified_Cobitis;

/// <summary>
/// Abstract class for unclassified Cobitis (no rank).
/// NCBI TaxId: 2620750
/// </summary>
public abstract class unclassified_Cobitis : Cobitis, Iunclassified_Cobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620750;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cobitis";
}
