using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Neodontobutis;

/// <summary>
/// Abstract class for Neodontobutis (genus).
/// NCBI TaxId: 2065823
/// </summary>
public abstract class Neodontobutis : Odontobutidae, INeodontobutis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neodontobutis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2065823;

    /// <inheritdoc />
    public virtual string GenusName => "Neodontobutis";

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
