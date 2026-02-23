using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Serrapinnus;

/// <summary>
/// Abstract class for Serrapinnus (genus).
/// NCBI TaxId: 870162
/// </summary>
public abstract class Serrapinnus : Characidae, ISerrapinnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serrapinnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 870162;

    /// <inheritdoc />
    public virtual string GenusName => "Serrapinnus";

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
