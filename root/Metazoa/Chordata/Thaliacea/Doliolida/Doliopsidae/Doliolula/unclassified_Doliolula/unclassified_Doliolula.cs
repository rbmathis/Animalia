using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliopsidae.Doliolula;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliopsidae.Doliolula.unclassified_Doliolula;

/// <summary>
/// Abstract class for unclassified Doliolula (no rank).
/// NCBI TaxId: 3065386
/// </summary>
public abstract class unclassified_Doliolula : Doliolula, Iunclassified_Doliolula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doliolula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3065386;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doliolula";
}
