using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Procavia;

/// <summary>
/// Abstract class for Procavia (genus).
/// NCBI TaxId: 9812
/// </summary>
public abstract class Procavia : Procaviidae, IProcavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9812;

    /// <inheritdoc />
    public virtual string GenusName => "Procavia";

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
