using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Grammatorcynus;

/// <summary>
/// Abstract class for Grammatorcynus (genus).
/// NCBI TaxId: 248139
/// </summary>
public abstract class Grammatorcynus : Scombridae, IGrammatorcynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammatorcynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248139;

    /// <inheritdoc />
    public virtual string GenusName => "Grammatorcynus";

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
