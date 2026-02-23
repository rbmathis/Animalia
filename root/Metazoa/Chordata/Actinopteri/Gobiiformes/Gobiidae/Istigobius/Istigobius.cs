using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Istigobius;

/// <summary>
/// Abstract class for Istigobius (genus).
/// NCBI TaxId: 150305
/// </summary>
public abstract class Istigobius : Gobiidae, IIstigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Istigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150305;

    /// <inheritdoc />
    public virtual string GenusName => "Istigobius";

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
