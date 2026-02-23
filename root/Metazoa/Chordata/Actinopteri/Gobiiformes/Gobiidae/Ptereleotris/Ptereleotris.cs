using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ptereleotris;

/// <summary>
/// Abstract class for Ptereleotris (genus).
/// NCBI TaxId: 86206
/// </summary>
public abstract class Ptereleotris : Gobiidae, IPtereleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptereleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86206;

    /// <inheritdoc />
    public virtual string GenusName => "Ptereleotris";

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
