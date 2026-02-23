using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Heterohyrax;

/// <summary>
/// Abstract class for Heterohyrax (genus).
/// NCBI TaxId: 77597
/// </summary>
public abstract class Heterohyrax : Procaviidae, IHeterohyrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterohyrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77597;

    /// <inheritdoc />
    public virtual string GenusName => "Heterohyrax";

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
