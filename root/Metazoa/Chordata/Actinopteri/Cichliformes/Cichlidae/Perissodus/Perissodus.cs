using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Perissodus;

/// <summary>
/// Abstract class for Perissodus (genus).
/// NCBI TaxId: 27758
/// </summary>
public abstract class Perissodus : Cichlidae, IPerissodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perissodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27758;

    /// <inheritdoc />
    public virtual string GenusName => "Perissodus";

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
