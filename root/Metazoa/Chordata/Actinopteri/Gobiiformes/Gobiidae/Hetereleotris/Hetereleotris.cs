using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hetereleotris;

/// <summary>
/// Abstract class for Hetereleotris (genus).
/// NCBI TaxId: 2067727
/// </summary>
public abstract class Hetereleotris : Gobiidae, IHetereleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hetereleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2067727;

    /// <inheritdoc />
    public virtual string GenusName => "Hetereleotris";

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
