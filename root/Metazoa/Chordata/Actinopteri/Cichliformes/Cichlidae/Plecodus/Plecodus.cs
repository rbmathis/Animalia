using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Plecodus;

/// <summary>
/// Abstract class for Plecodus (genus).
/// NCBI TaxId: 167845
/// </summary>
public abstract class Plecodus : Cichlidae, IPlecodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plecodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167845;

    /// <inheritdoc />
    public virtual string GenusName => "Plecodus";

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
