using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gymneleotris;

/// <summary>
/// Abstract class for Gymneleotris (genus).
/// NCBI TaxId: 1365689
/// </summary>
public abstract class Gymneleotris : Gobiidae, IGymneleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymneleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365689;

    /// <inheritdoc />
    public virtual string GenusName => "Gymneleotris";

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
