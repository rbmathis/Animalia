using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Spicomacrurus;

/// <summary>
/// Abstract class for Spicomacrurus (genus).
/// NCBI TaxId: 2768297
/// </summary>
public abstract class Spicomacrurus : Macrouridae, ISpicomacrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spicomacrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768297;

    /// <inheritdoc />
    public virtual string GenusName => "Spicomacrurus";

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
