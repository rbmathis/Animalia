using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Pagellus;

/// <summary>
/// Abstract class for Pagellus (genus).
/// NCBI TaxId: 50592
/// </summary>
public abstract class Pagellus : Sparidae, IPagellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50592;

    /// <inheritdoc />
    public virtual string GenusName => "Pagellus";

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
