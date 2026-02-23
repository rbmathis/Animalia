using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Kottelatia;

/// <summary>
/// Abstract class for Kottelatia (genus).
/// NCBI TaxId: 1913196
/// </summary>
public abstract class Kottelatia : Danionidae, IKottelatia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kottelatia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1913196;

    /// <inheritdoc />
    public virtual string GenusName => "Kottelatia";

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
