using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteochilus;

/// <summary>
/// Abstract class for Osteochilus (genus).
/// NCBI TaxId: 227287
/// </summary>
public abstract class Osteochilus : Cyprinidae, IOsteochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227287;

    /// <inheritdoc />
    public virtual string GenusName => "Osteochilus";

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
