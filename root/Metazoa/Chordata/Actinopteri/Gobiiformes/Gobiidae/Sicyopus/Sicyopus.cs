using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicyopus;

/// <summary>
/// Abstract class for Sicyopus (genus).
/// NCBI TaxId: 936280
/// </summary>
public abstract class Sicyopus : Gobiidae, ISicyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sicyopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 936280;

    /// <inheritdoc />
    public virtual string GenusName => "Sicyopus";

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
