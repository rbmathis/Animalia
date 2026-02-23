using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae.Polyprion;

/// <summary>
/// Abstract class for Polyprion (genus).
/// NCBI TaxId: 112727
/// </summary>
public abstract class Polyprion : Polyprionidae, IPolyprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 112727;

    /// <inheritdoc />
    public virtual string GenusName => "Polyprion";

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
