using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Lepidorhynchus;

/// <summary>
/// Abstract class for Lepidorhynchus (genus).
/// NCBI TaxId: 2485027
/// </summary>
public abstract class Lepidorhynchus : Macrouridae, ILepidorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485027;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidorhynchus";

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
