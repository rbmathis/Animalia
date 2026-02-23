using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Limnichthys;

/// <summary>
/// Abstract class for Limnichthys (genus).
/// NCBI TaxId: 270599
/// </summary>
public abstract class Limnichthys : Creediidae, ILimnichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270599;

    /// <inheritdoc />
    public virtual string GenusName => "Limnichthys";

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
