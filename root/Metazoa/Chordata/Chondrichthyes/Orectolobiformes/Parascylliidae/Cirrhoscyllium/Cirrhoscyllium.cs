using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Parascylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Parascylliidae.Cirrhoscyllium;

/// <summary>
/// Abstract class for Cirrhoscyllium (genus).
/// NCBI TaxId: 1213743
/// </summary>
public abstract class Cirrhoscyllium : Parascylliidae, ICirrhoscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhoscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1213743;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhoscyllium";

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
