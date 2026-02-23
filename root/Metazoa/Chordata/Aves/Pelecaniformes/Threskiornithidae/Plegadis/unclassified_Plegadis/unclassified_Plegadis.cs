using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Plegadis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Plegadis.unclassified_Plegadis;

/// <summary>
/// Abstract class for unclassified Plegadis (no rank).
/// NCBI TaxId: 2622411
/// </summary>
public abstract class unclassified_Plegadis : Plegadis, Iunclassified_Plegadis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plegadis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622411;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plegadis";
}
