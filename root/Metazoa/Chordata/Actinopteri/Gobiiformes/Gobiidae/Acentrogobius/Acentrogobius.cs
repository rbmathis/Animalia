using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Acentrogobius;

/// <summary>
/// Abstract class for Acentrogobius (genus).
/// NCBI TaxId: 376738
/// </summary>
public abstract class Acentrogobius : Gobiidae, IAcentrogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acentrogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376738;

    /// <inheritdoc />
    public virtual string GenusName => "Acentrogobius";

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
