using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Ficedula;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Ficedula.unclassified_Ficedula;

/// <summary>
/// Abstract class for unclassified Ficedula (no rank).
/// NCBI TaxId: 3297696
/// </summary>
public abstract class unclassified_Ficedula : Ficedula, Iunclassified_Ficedula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ficedula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3297696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ficedula";
}
