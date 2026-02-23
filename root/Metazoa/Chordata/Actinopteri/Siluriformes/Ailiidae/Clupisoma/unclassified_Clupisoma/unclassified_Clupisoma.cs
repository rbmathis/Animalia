using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Clupisoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Clupisoma.unclassified_Clupisoma;

/// <summary>
/// Abstract class for unclassified Clupisoma (no rank).
/// NCBI TaxId: 2626718
/// </summary>
public abstract class unclassified_Clupisoma : Clupisoma, Iunclassified_Clupisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clupisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626718;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clupisoma";
}
