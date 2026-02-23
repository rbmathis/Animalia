using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Ladigesocypris;

/// <summary>
/// Abstract class for Ladigesocypris (genus).
/// NCBI TaxId: 108513
/// </summary>
public abstract class Ladigesocypris : Leuciscidae, ILadigesocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ladigesocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108513;

    /// <inheritdoc />
    public virtual string GenusName => "Ladigesocypris";

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
