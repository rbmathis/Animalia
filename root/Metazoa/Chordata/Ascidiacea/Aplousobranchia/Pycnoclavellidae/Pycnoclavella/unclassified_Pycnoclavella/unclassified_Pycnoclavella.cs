using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pycnoclavellidae.Pycnoclavella;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pycnoclavellidae.Pycnoclavella.unclassified_Pycnoclavella;

/// <summary>
/// Abstract class for unclassified Pycnoclavella (no rank).
/// NCBI TaxId: 2618789
/// </summary>
public abstract class unclassified_Pycnoclavella : Pycnoclavella, Iunclassified_Pycnoclavella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pycnoclavella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618789;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pycnoclavella";
}
