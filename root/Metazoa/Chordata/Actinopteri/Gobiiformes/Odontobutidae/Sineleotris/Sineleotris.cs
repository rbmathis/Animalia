using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Sineleotris;

/// <summary>
/// Abstract class for Sineleotris (genus).
/// NCBI TaxId: 2065824
/// </summary>
public abstract class Sineleotris : Odontobutidae, ISineleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sineleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2065824;

    /// <inheritdoc />
    public virtual string GenusName => "Sineleotris";

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
