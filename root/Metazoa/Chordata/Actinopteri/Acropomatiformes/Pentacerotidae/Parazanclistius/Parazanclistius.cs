using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Parazanclistius;

/// <summary>
/// Abstract class for Parazanclistius (genus).
/// NCBI TaxId: 1680630
/// </summary>
public abstract class Parazanclistius : Pentacerotidae, IParazanclistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parazanclistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1680630;

    /// <inheritdoc />
    public virtual string GenusName => "Parazanclistius";

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
