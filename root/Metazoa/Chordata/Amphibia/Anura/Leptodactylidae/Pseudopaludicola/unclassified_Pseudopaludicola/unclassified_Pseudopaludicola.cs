using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pseudopaludicola;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pseudopaludicola.unclassified_Pseudopaludicola;

/// <summary>
/// Abstract class for unclassified Pseudopaludicola (no rank).
/// NCBI TaxId: 2636570
/// </summary>
public abstract class unclassified_Pseudopaludicola : Pseudopaludicola, Iunclassified_Pseudopaludicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudopaludicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636570;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudopaludicola";
}
