using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae.Trichodon;

/// <summary>
/// Abstract class for Trichodon (genus).
/// NCBI TaxId: 209540
/// </summary>
public abstract class Trichodon : Trichodontidae, ITrichodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209540;

    /// <inheritdoc />
    public virtual string GenusName => "Trichodon";

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
