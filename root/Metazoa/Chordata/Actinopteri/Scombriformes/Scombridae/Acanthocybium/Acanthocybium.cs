using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Acanthocybium;

/// <summary>
/// Abstract class for Acanthocybium (genus).
/// NCBI TaxId: 13322
/// </summary>
public abstract class Acanthocybium : Scombridae, IAcanthocybium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthocybium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13322;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthocybium";

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
