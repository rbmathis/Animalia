using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae.Boulengerula;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae.Boulengerula.unclassified_Boulengerula;

/// <summary>
/// Abstract class for unclassified Boulengerula (no rank).
/// NCBI TaxId: 2619590
/// </summary>
public abstract class unclassified_Boulengerula : Boulengerula, Iunclassified_Boulengerula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boulengerula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619590;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boulengerula";
}
