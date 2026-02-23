using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aboma;

/// <summary>
/// Abstract class for Aboma (genus).
/// NCBI TaxId: 203276
/// </summary>
public abstract class Aboma : Gobiidae, IAboma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aboma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203276;

    /// <inheritdoc />
    public virtual string GenusName => "Aboma";

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
