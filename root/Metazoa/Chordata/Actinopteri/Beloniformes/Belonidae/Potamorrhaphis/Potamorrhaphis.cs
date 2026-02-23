using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Potamorrhaphis;

/// <summary>
/// Abstract class for Potamorrhaphis (genus).
/// NCBI TaxId: 105854
/// </summary>
public abstract class Potamorrhaphis : Belonidae, IPotamorrhaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamorrhaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 105854;

    /// <inheritdoc />
    public virtual string GenusName => "Potamorrhaphis";

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
