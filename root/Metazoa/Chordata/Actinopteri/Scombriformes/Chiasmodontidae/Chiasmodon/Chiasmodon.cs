using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Chiasmodon;

/// <summary>
/// Abstract class for Chiasmodon (genus).
/// NCBI TaxId: 1154618
/// </summary>
public abstract class Chiasmodon : Chiasmodontidae, IChiasmodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiasmodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154618;

    /// <inheritdoc />
    public virtual string GenusName => "Chiasmodon";

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
