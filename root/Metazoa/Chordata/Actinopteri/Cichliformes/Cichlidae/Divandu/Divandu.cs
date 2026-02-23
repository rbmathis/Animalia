using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Divandu;

/// <summary>
/// Abstract class for Divandu (genus).
/// NCBI TaxId: 1543265
/// </summary>
public abstract class Divandu : Cichlidae, IDivandu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Divandu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543265;

    /// <inheritdoc />
    public virtual string GenusName => "Divandu";

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
