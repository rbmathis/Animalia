using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Apistogramma;

/// <summary>
/// Abstract class for Apistogramma (genus).
/// NCBI TaxId: 81357
/// </summary>
public abstract class Apistogramma : Cichlidae, IApistogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apistogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81357;

    /// <inheritdoc />
    public virtual string GenusName => "Apistogramma";

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
