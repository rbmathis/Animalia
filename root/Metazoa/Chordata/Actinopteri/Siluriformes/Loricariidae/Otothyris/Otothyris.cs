using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Otothyris;

/// <summary>
/// Abstract class for Otothyris (genus).
/// NCBI TaxId: 510792
/// </summary>
public abstract class Otothyris : Loricariidae, IOtothyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otothyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510792;

    /// <inheritdoc />
    public virtual string GenusName => "Otothyris";

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
