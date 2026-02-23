using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Tylosurus;

/// <summary>
/// Abstract class for Tylosurus (genus).
/// NCBI TaxId: 129072
/// </summary>
public abstract class Tylosurus : Belonidae, ITylosurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylosurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129072;

    /// <inheritdoc />
    public virtual string GenusName => "Tylosurus";

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
