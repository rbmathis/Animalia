using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Argonectes;

/// <summary>
/// Abstract class for Argonectes (genus).
/// NCBI TaxId: 930296
/// </summary>
public abstract class Argonectes : Hemiodontidae, IArgonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930296;

    /// <inheritdoc />
    public virtual string GenusName => "Argonectes";

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
