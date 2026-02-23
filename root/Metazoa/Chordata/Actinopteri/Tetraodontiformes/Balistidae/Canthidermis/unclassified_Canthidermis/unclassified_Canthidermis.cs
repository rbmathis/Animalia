using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Canthidermis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Canthidermis.unclassified_Canthidermis;

/// <summary>
/// Abstract class for unclassified Canthidermis (no rank).
/// NCBI TaxId: 2725565
/// </summary>
public abstract class unclassified_Canthidermis : Canthidermis, Iunclassified_Canthidermis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Canthidermis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2725565;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Canthidermis";
}
