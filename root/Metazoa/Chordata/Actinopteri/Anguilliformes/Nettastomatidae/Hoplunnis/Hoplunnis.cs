using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Hoplunnis;

/// <summary>
/// Abstract class for Hoplunnis (genus).
/// NCBI TaxId: 182430
/// </summary>
public abstract class Hoplunnis : Nettastomatidae, IHoplunnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplunnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182430;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplunnis";

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
