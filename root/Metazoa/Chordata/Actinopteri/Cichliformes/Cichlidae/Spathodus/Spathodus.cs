using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Spathodus;

/// <summary>
/// Abstract class for Spathodus (genus).
/// NCBI TaxId: 52955
/// </summary>
public abstract class Spathodus : Cichlidae, ISpathodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spathodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52955;

    /// <inheritdoc />
    public virtual string GenusName => "Spathodus";

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
