using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Nandidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Nandidae.Nandus;

/// <summary>
/// Abstract class for Nandus (genus).
/// NCBI TaxId: 248995
/// </summary>
public abstract class Nandus : Nandidae, INandus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nandus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248995;

    /// <inheritdoc />
    public virtual string GenusName => "Nandus";

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
