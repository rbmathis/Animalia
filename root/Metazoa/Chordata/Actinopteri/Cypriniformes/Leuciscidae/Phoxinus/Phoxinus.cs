using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Phoxinus;

/// <summary>
/// Abstract class for Phoxinus (genus).
/// NCBI TaxId: 42662
/// </summary>
public abstract class Phoxinus : Leuciscidae, IPhoxinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoxinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42662;

    /// <inheritdoc />
    public virtual string GenusName => "Phoxinus";

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
