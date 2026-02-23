using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Gymnammodytes;

/// <summary>
/// Abstract class for Gymnammodytes (genus).
/// NCBI TaxId: 1306752
/// </summary>
public abstract class Gymnammodytes : Ammodytidae, IGymnammodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnammodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306752;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnammodytes";

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
