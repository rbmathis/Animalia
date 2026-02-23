using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Dentex;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Dentex.unclassified_Dentex;

/// <summary>
/// Abstract class for unclassified Dentex (no rank).
/// NCBI TaxId: 2637985
/// </summary>
public abstract class unclassified_Dentex : Dentex, Iunclassified_Dentex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dentex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637985;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dentex";
}
