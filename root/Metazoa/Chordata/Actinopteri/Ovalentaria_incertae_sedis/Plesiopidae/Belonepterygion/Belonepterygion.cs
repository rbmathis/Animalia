using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Belonepterygion;

/// <summary>
/// Abstract class for Belonepterygion (genus).
/// NCBI TaxId: 1064598
/// </summary>
public abstract class Belonepterygion : Plesiopidae, IBelonepterygion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belonepterygion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1064598;

    /// <inheritdoc />
    public virtual string GenusName => "Belonepterygion";

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
