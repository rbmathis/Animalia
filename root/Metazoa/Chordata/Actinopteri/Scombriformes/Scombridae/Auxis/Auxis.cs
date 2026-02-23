using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Auxis;

/// <summary>
/// Abstract class for Auxis (genus).
/// NCBI TaxId: 13352
/// </summary>
public abstract class Auxis : Scombridae, IAuxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13352;

    /// <inheritdoc />
    public virtual string GenusName => "Auxis";

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
