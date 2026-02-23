using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Batrachocephalus;

/// <summary>
/// Abstract class for Batrachocephalus (genus).
/// NCBI TaxId: 2862887
/// </summary>
public abstract class Batrachocephalus : Ariidae, IBatrachocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2862887;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachocephalus";

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
