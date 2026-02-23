using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Parajulis;

/// <summary>
/// Abstract class for Parajulis (genus).
/// NCBI TaxId: 356779
/// </summary>
public abstract class Parajulis : Labridae, IParajulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parajulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356779;

    /// <inheritdoc />
    public virtual string GenusName => "Parajulis";

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
