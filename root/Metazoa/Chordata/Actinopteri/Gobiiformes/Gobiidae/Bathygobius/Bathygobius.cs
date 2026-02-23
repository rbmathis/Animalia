using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bathygobius;

/// <summary>
/// Abstract class for Bathygobius (genus).
/// NCBI TaxId: 163631
/// </summary>
public abstract class Bathygobius : Gobiidae, IBathygobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathygobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163631;

    /// <inheritdoc />
    public virtual string GenusName => "Bathygobius";

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
