using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hypsophrys;

/// <summary>
/// Abstract class for Hypsophrys (genus).
/// NCBI TaxId: 63171
/// </summary>
public abstract class Hypsophrys : Cichlidae, IHypsophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63171;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsophrys";

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
