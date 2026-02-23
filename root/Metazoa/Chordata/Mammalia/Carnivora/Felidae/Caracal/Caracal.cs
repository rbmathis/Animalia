using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Caracal;

/// <summary>
/// Abstract class for Caracal (genus).
/// NCBI TaxId: 61393
/// </summary>
public abstract class Caracal : Felidae, ICaracal
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caracal";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61393;

    /// <inheritdoc />
    public virtual string GenusName => "Caracal";

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
