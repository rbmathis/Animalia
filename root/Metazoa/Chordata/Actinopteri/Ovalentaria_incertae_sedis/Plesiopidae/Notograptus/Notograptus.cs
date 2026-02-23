using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Notograptus;

/// <summary>
/// Abstract class for Notograptus (genus).
/// NCBI TaxId: 1064599
/// </summary>
public abstract class Notograptus : Plesiopidae, INotograptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notograptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1064599;

    /// <inheritdoc />
    public virtual string GenusName => "Notograptus";

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
