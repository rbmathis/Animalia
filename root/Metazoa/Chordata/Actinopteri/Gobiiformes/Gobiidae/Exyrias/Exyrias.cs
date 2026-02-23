using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Exyrias;

/// <summary>
/// Abstract class for Exyrias (genus).
/// NCBI TaxId: 150295
/// </summary>
public abstract class Exyrias : Gobiidae, IExyrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exyrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150295;

    /// <inheritdoc />
    public virtual string GenusName => "Exyrias";

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
