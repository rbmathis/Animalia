using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.unclassified_Doliolidae;

/// <summary>
/// Abstract class for unclassified Doliolidae (no rank).
/// NCBI TaxId: 3061393
/// </summary>
public abstract class unclassified_Doliolidae : Doliolidae, Iunclassified_Doliolidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doliolidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3061393;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doliolidae";
}
