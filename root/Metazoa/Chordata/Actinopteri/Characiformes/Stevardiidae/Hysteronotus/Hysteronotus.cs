using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hysteronotus;

/// <summary>
/// Abstract class for Hysteronotus (genus).
/// NCBI TaxId: 2517894
/// </summary>
public abstract class Hysteronotus : Stevardiidae, IHysteronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hysteronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2517894;

    /// <inheritdoc />
    public virtual string GenusName => "Hysteronotus";

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
