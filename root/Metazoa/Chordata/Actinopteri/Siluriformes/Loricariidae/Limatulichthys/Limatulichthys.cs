using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Limatulichthys;

/// <summary>
/// Abstract class for Limatulichthys (genus).
/// NCBI TaxId: 503147
/// </summary>
public abstract class Limatulichthys : Loricariidae, ILimatulichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limatulichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503147;

    /// <inheritdoc />
    public virtual string GenusName => "Limatulichthys";

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
