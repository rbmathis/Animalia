using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudophoxinus;

/// <summary>
/// Abstract class for Pseudophoxinus (genus).
/// NCBI TaxId: 101888
/// </summary>
public abstract class Pseudophoxinus : Leuciscidae, IPseudophoxinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudophoxinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101888;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudophoxinus";

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
