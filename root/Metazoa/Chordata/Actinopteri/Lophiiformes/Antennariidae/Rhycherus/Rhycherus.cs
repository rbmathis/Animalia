using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Rhycherus;

/// <summary>
/// Abstract class for Rhycherus (genus).
/// NCBI TaxId: 882775
/// </summary>
public abstract class Rhycherus : Antennariidae, IRhycherus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhycherus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882775;

    /// <inheritdoc />
    public virtual string GenusName => "Rhycherus";

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
