using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Belonophago;

/// <summary>
/// Abstract class for Belonophago (genus).
/// NCBI TaxId: 1108132
/// </summary>
public abstract class Belonophago : Distichodontidae, IBelonophago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belonophago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108132;

    /// <inheritdoc />
    public virtual string GenusName => "Belonophago";

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
