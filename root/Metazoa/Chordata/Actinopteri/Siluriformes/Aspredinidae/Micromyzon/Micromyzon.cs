using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Micromyzon;

/// <summary>
/// Abstract class for Micromyzon (genus).
/// NCBI TaxId: 390448
/// </summary>
public abstract class Micromyzon : Aspredinidae, IMicromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390448;

    /// <inheritdoc />
    public virtual string GenusName => "Micromyzon";

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
