using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae.Popondichthys;

/// <summary>
/// Abstract class for Popondichthys (genus).
/// NCBI TaxId: 1498631
/// </summary>
public abstract class Popondichthys : Pseudomugilidae, IPopondichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Popondichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1498631;

    /// <inheritdoc />
    public virtual string GenusName => "Popondichthys";

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
