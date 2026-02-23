using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coelorinchus;

/// <summary>
/// Abstract class for Coelorinchus (genus).
/// NCBI TaxId: 83393
/// </summary>
public abstract class Coelorinchus : Macrouridae, ICoelorinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coelorinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83393;

    /// <inheritdoc />
    public virtual string GenusName => "Coelorinchus";

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
