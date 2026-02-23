using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicyopterus;

/// <summary>
/// Abstract class for Sicyopterus (genus).
/// NCBI TaxId: 70085
/// </summary>
public abstract class Sicyopterus : Gobiidae, ISicyopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sicyopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70085;

    /// <inheritdoc />
    public virtual string GenusName => "Sicyopterus";

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
