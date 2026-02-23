using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Emmelichthyops;

/// <summary>
/// Abstract class for Emmelichthyops (genus).
/// NCBI TaxId: 1010785
/// </summary>
public abstract class Emmelichthyops : Haemulidae, IEmmelichthyops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emmelichthyops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1010785;

    /// <inheritdoc />
    public virtual string GenusName => "Emmelichthyops";

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
