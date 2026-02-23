using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiodon;

/// <summary>
/// Abstract class for Gobiodon (genus).
/// NCBI TaxId: 150299
/// </summary>
public abstract class Gobiodon : Gobiidae, IGobiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150299;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiodon";

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
