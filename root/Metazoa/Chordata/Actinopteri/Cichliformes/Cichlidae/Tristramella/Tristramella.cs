using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tristramella;

/// <summary>
/// Abstract class for Tristramella (genus).
/// NCBI TaxId: 158783
/// </summary>
public abstract class Tristramella : Cichlidae, ITristramella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tristramella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158783;

    /// <inheritdoc />
    public virtual string GenusName => "Tristramella";

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
