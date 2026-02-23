using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae.Kiunga;

/// <summary>
/// Abstract class for Kiunga (genus).
/// NCBI TaxId: 1643414
/// </summary>
public abstract class Kiunga : Pseudomugilidae, IKiunga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kiunga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1643414;

    /// <inheritdoc />
    public virtual string GenusName => "Kiunga";

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
