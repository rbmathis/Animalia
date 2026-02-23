using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Parachaetodon;

/// <summary>
/// Abstract class for Parachaetodon (genus).
/// NCBI TaxId: 109919
/// </summary>
public abstract class Parachaetodon : Chaetodontidae, IParachaetodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachaetodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109919;

    /// <inheritdoc />
    public virtual string GenusName => "Parachaetodon";

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
