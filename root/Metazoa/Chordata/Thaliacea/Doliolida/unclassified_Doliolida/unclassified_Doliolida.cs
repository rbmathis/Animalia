using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.unclassified_Doliolida;

/// <summary>
/// Abstract class for unclassified Doliolida (no rank).
/// NCBI TaxId: 2072422
/// </summary>
public abstract class unclassified_Doliolida : Doliolida, Iunclassified_Doliolida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doliolida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2072422;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doliolida";
}
