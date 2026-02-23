using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Malacosteus;

/// <summary>
/// Abstract class for Malacosteus (genus).
/// NCBI TaxId: 76142
/// </summary>
public abstract class Malacosteus : Stomiidae, IMalacosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76142;

    /// <inheritdoc />
    public virtual string GenusName => "Malacosteus";

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
