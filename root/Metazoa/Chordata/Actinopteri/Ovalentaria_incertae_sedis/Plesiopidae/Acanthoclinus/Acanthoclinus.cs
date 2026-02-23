using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Acanthoclinus;

/// <summary>
/// Abstract class for Acanthoclinus (genus).
/// NCBI TaxId: 1064596
/// </summary>
public abstract class Acanthoclinus : Plesiopidae, IAcanthoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1064596;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthoclinus";

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
