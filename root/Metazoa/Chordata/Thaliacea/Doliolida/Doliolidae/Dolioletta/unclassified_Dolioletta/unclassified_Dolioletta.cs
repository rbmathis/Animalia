using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Dolioletta;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Dolioletta.unclassified_Dolioletta;

/// <summary>
/// Abstract class for unclassified Dolioletta (no rank).
/// NCBI TaxId: 2978589
/// </summary>
public abstract class unclassified_Dolioletta : Dolioletta, Iunclassified_Dolioletta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dolioletta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2978589;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dolioletta";
}
