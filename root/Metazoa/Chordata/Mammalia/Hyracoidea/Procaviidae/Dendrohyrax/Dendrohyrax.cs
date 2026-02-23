using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Dendrohyrax;

/// <summary>
/// Abstract class for Dendrohyrax (genus).
/// NCBI TaxId: 42324
/// </summary>
public abstract class Dendrohyrax : Procaviidae, IDendrohyrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrohyrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42324;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrohyrax";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
