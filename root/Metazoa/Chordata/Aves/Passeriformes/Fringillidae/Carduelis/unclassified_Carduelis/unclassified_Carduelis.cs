using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Carduelis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Carduelis.unclassified_Carduelis;

/// <summary>
/// Abstract class for unclassified Carduelis (no rank).
/// NCBI TaxId: 2632962
/// </summary>
public abstract class unclassified_Carduelis : Carduelis, Iunclassified_Carduelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carduelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632962;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carduelis";
}
