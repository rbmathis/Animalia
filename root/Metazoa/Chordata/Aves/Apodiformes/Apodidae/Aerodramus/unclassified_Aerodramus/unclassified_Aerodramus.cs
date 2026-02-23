using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aerodramus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aerodramus.unclassified_Aerodramus;

/// <summary>
/// Abstract class for unclassified Aerodramus (no rank).
/// NCBI TaxId: 2631932
/// </summary>
public abstract class unclassified_Aerodramus : Aerodramus, Iunclassified_Aerodramus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aerodramus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631932;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aerodramus";
}
