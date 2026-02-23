using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Gasterochisma;

/// <summary>
/// Abstract class for Gasterochisma (genus).
/// NCBI TaxId: 13536
/// </summary>
public abstract class Gasterochisma : Scombridae, IGasterochisma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gasterochisma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13536;

    /// <inheritdoc />
    public virtual string GenusName => "Gasterochisma";

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
