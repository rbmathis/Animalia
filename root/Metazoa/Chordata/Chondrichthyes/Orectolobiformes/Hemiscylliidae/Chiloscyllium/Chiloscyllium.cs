using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae.Chiloscyllium;

/// <summary>
/// Abstract class for Chiloscyllium (genus).
/// NCBI TaxId: 34767
/// </summary>
public abstract class Chiloscyllium : Hemiscylliidae, IChiloscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiloscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34767;

    /// <inheritdoc />
    public virtual string GenusName => "Chiloscyllium";

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
