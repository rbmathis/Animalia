using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Teleogramma;

/// <summary>
/// Abstract class for Teleogramma (genus).
/// NCBI TaxId: 219368
/// </summary>
public abstract class Teleogramma : Cichlidae, ITeleogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teleogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 219368;

    /// <inheritdoc />
    public virtual string GenusName => "Teleogramma";

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
