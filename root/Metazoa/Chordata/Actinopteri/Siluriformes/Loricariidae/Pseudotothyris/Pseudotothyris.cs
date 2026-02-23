using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudotothyris;

/// <summary>
/// Abstract class for Pseudotothyris (genus).
/// NCBI TaxId: 321167
/// </summary>
public abstract class Pseudotothyris : Loricariidae, IPseudotothyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotothyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321167;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotothyris";

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
