using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Hozukius;

/// <summary>
/// Abstract class for Hozukius (genus).
/// NCBI TaxId: 201711
/// </summary>
public abstract class Hozukius : Sebastidae, IHozukius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hozukius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201711;

    /// <inheritdoc />
    public virtual string GenusName => "Hozukius";

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
