using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Zanclistius;

/// <summary>
/// Abstract class for Zanclistius (genus).
/// NCBI TaxId: 334883
/// </summary>
public abstract class Zanclistius : Pentacerotidae, IZanclistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zanclistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334883;

    /// <inheritdoc />
    public virtual string GenusName => "Zanclistius";

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
