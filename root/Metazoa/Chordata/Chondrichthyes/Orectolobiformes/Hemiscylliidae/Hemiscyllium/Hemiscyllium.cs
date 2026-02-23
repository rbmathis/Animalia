using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae.Hemiscyllium;

/// <summary>
/// Abstract class for Hemiscyllium (genus).
/// NCBI TaxId: 170819
/// </summary>
public abstract class Hemiscyllium : Hemiscylliidae, IHemiscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170819;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiscyllium";

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
