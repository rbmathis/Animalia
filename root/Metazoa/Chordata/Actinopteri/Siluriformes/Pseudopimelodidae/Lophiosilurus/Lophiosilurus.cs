using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Lophiosilurus;

/// <summary>
/// Abstract class for Lophiosilurus (genus).
/// NCBI TaxId: 490145
/// </summary>
public abstract class Lophiosilurus : Pseudopimelodidae, ILophiosilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiosilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490145;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiosilurus";

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
