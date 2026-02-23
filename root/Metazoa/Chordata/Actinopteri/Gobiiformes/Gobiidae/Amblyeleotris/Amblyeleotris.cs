using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblyeleotris;

/// <summary>
/// Abstract class for Amblyeleotris (genus).
/// NCBI TaxId: 150257
/// </summary>
public abstract class Amblyeleotris : Gobiidae, IAmblyeleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyeleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150257;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyeleotris";

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
