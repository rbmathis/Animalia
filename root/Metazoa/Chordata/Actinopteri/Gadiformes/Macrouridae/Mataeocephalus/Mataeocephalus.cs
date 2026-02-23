using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Mataeocephalus;

/// <summary>
/// Abstract class for Mataeocephalus (genus).
/// NCBI TaxId: 1812881
/// </summary>
public abstract class Mataeocephalus : Macrouridae, IMataeocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mataeocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812881;

    /// <inheritdoc />
    public virtual string GenusName => "Mataeocephalus";

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
