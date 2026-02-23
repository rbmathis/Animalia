using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Odontamblyopus;

/// <summary>
/// Abstract class for Odontamblyopus (genus).
/// NCBI TaxId: 166753
/// </summary>
public abstract class Odontamblyopus : Gobiidae, IOdontamblyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontamblyopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166753;

    /// <inheritdoc />
    public virtual string GenusName => "Odontamblyopus";

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
