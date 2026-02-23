using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Megalechis;

/// <summary>
/// Abstract class for Megalechis (genus).
/// NCBI TaxId: 245777
/// </summary>
public abstract class Megalechis : Callichthyidae, IMegalechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245777;

    /// <inheritdoc />
    public virtual string GenusName => "Megalechis";

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
