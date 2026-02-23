using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Neogobius;

/// <summary>
/// Abstract class for Neogobius (genus).
/// NCBI TaxId: 47307
/// </summary>
public abstract class Neogobius : Gobiidae, INeogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47307;

    /// <inheritdoc />
    public virtual string GenusName => "Neogobius";

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
