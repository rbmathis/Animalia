using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Amphichaetodon;

/// <summary>
/// Abstract class for Amphichaetodon (genus).
/// NCBI TaxId: 272791
/// </summary>
public abstract class Amphichaetodon : Chaetodontidae, IAmphichaetodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphichaetodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272791;

    /// <inheritdoc />
    public virtual string GenusName => "Amphichaetodon";

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
