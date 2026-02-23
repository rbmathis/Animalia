using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Saurida;

/// <summary>
/// Abstract class for Saurida (genus).
/// NCBI TaxId: 143309
/// </summary>
public abstract class Saurida : Synodontidae, ISaurida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saurida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143309;

    /// <inheritdoc />
    public virtual string GenusName => "Saurida";

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
