using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Microspingus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Microspingus.unclassified_Microspingus;

/// <summary>
/// Abstract class for unclassified Microspingus (no rank).
/// NCBI TaxId: 3475718
/// </summary>
public abstract class unclassified_Microspingus : Microspingus, Iunclassified_Microspingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microspingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3475718;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microspingus";
}
