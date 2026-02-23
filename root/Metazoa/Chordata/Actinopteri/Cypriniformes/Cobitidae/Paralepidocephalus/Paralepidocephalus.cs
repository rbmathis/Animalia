using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Paralepidocephalus;

/// <summary>
/// Abstract class for Paralepidocephalus (genus).
/// NCBI TaxId: 2991286
/// </summary>
public abstract class Paralepidocephalus : Cobitidae, IParalepidocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralepidocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2991286;

    /// <inheritdoc />
    public virtual string GenusName => "Paralepidocephalus";

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
