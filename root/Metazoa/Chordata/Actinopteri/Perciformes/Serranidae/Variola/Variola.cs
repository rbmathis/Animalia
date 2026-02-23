using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Variola;

/// <summary>
/// Abstract class for Variola (genus).
/// NCBI TaxId: 300414
/// </summary>
public abstract class Variola : Serranidae, IVariola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Variola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300414;

    /// <inheritdoc />
    public virtual string GenusName => "Variola";

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
