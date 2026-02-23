using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Chaetodon;

/// <summary>
/// Abstract class for Chaetodon (genus).
/// NCBI TaxId: 37948
/// </summary>
public abstract class Chaetodon : Chaetodontidae, IChaetodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37948;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetodon";

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
