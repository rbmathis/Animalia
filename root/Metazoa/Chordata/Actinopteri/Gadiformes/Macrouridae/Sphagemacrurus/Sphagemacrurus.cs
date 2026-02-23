using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Sphagemacrurus;

/// <summary>
/// Abstract class for Sphagemacrurus (genus).
/// NCBI TaxId: 473386
/// </summary>
public abstract class Sphagemacrurus : Macrouridae, ISphagemacrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphagemacrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473386;

    /// <inheritdoc />
    public virtual string GenusName => "Sphagemacrurus";

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
