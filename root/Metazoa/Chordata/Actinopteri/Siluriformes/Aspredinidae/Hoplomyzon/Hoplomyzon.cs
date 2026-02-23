using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Hoplomyzon;

/// <summary>
/// Abstract class for Hoplomyzon (genus).
/// NCBI TaxId: 385299
/// </summary>
public abstract class Hoplomyzon : Aspredinidae, IHoplomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385299;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplomyzon";

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
