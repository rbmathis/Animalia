using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae.Thalasseleotris;

/// <summary>
/// Abstract class for Thalasseleotris (genus).
/// NCBI TaxId: 376889
/// </summary>
public abstract class Thalasseleotris : Thalasseleotrididae, IThalasseleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalasseleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376889;

    /// <inheritdoc />
    public virtual string GenusName => "Thalasseleotris";

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
