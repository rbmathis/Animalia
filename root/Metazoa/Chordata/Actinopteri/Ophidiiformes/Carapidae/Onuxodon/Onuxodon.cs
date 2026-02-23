using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Onuxodon;

/// <summary>
/// Abstract class for Onuxodon (genus).
/// NCBI TaxId: 1003971
/// </summary>
public abstract class Onuxodon : Carapidae, IOnuxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Onuxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003971;

    /// <inheritdoc />
    public virtual string GenusName => "Onuxodon";

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
