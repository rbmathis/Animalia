using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae.Arctoscopus;

/// <summary>
/// Abstract class for Arctoscopus (genus).
/// NCBI TaxId: 148606
/// </summary>
public abstract class Arctoscopus : Trichodontidae, IArctoscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctoscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148606;

    /// <inheritdoc />
    public virtual string GenusName => "Arctoscopus";

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
