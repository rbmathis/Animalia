using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Porogobius;

/// <summary>
/// Abstract class for Porogobius (genus).
/// NCBI TaxId: 1365710
/// </summary>
public abstract class Porogobius : Gobiidae, IPorogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365710;

    /// <inheritdoc />
    public virtual string GenusName => "Porogobius";

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
