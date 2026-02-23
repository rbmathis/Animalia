using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae.Pseudomugil;

/// <summary>
/// Abstract class for Pseudomugil (genus).
/// NCBI TaxId: 160494
/// </summary>
public abstract class Pseudomugil : Pseudomugilidae, IPseudomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160494;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudomugil";

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
