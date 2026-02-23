using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Hymenocephalus;

/// <summary>
/// Abstract class for Hymenocephalus (genus).
/// NCBI TaxId: 630731
/// </summary>
public abstract class Hymenocephalus : Macrouridae, IHymenocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hymenocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 630731;

    /// <inheritdoc />
    public virtual string GenusName => "Hymenocephalus";

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
