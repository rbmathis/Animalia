using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Crystallogobius;

/// <summary>
/// Abstract class for Crystallogobius (genus).
/// NCBI TaxId: 441902
/// </summary>
public abstract class Crystallogobius : Gobiidae, ICrystallogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crystallogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 441902;

    /// <inheritdoc />
    public virtual string GenusName => "Crystallogobius";

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
