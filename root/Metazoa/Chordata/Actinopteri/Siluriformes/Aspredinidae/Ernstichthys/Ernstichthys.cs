using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Ernstichthys;

/// <summary>
/// Abstract class for Ernstichthys (genus).
/// NCBI TaxId: 2175995
/// </summary>
public abstract class Ernstichthys : Aspredinidae, IErnstichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ernstichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2175995;

    /// <inheritdoc />
    public virtual string GenusName => "Ernstichthys";

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
