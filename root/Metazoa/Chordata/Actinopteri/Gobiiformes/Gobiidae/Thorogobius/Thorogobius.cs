using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Thorogobius;

/// <summary>
/// Abstract class for Thorogobius (genus).
/// NCBI TaxId: 579950
/// </summary>
public abstract class Thorogobius : Gobiidae, IThorogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thorogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 579950;

    /// <inheritdoc />
    public virtual string GenusName => "Thorogobius";

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
