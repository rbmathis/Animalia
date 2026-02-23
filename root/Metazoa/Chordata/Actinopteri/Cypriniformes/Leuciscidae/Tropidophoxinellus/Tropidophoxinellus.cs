using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Tropidophoxinellus;

/// <summary>
/// Abstract class for Tropidophoxinellus (genus).
/// NCBI TaxId: 77805
/// </summary>
public abstract class Tropidophoxinellus : Leuciscidae, ITropidophoxinellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidophoxinellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77805;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidophoxinellus";

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
