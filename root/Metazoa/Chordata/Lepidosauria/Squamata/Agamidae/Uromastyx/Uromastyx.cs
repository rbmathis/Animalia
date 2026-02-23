using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Uromastyx;

/// <summary>
/// Abstract class for Uromastyx (genus).
/// NCBI TaxId: 40249
/// </summary>
public abstract class Uromastyx : Agamidae, IUromastyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uromastyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40249;

    /// <inheritdoc />
    public virtual string GenusName => "Uromastyx";

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
