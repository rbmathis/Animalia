using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Yasuhikotakia;

/// <summary>
/// Abstract class for Yasuhikotakia (genus).
/// NCBI TaxId: 322111
/// </summary>
public abstract class Yasuhikotakia : Botiidae, IYasuhikotakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yasuhikotakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322111;

    /// <inheritdoc />
    public virtual string GenusName => "Yasuhikotakia";

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
