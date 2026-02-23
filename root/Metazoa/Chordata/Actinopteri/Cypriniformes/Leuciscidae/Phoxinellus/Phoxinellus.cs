using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Phoxinellus;

/// <summary>
/// Abstract class for Phoxinellus (genus).
/// NCBI TaxId: 101910
/// </summary>
public abstract class Phoxinellus : Leuciscidae, IPhoxinellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoxinellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101910;

    /// <inheritdoc />
    public virtual string GenusName => "Phoxinellus";

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
