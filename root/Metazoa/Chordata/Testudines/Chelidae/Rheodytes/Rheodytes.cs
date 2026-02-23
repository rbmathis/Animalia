using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Rheodytes;

/// <summary>
/// Abstract class for Rheodytes (genus).
/// NCBI TaxId: 44527
/// </summary>
public abstract class Rheodytes : Chelidae, IRheodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44527;

    /// <inheritdoc />
    public virtual string GenusName => "Rheodytes";

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
