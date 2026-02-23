using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Photopectoralis;

/// <summary>
/// Abstract class for Photopectoralis (genus).
/// NCBI TaxId: 334404
/// </summary>
public abstract class Photopectoralis : Leiognathidae, IPhotopectoralis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Photopectoralis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334404;

    /// <inheritdoc />
    public virtual string GenusName => "Photopectoralis";

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
