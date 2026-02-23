using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Enneacanthus;

/// <summary>
/// Abstract class for Enneacanthus (genus).
/// NCBI TaxId: 71676
/// </summary>
public abstract class Enneacanthus : Centrarchidae, IEnneacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enneacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71676;

    /// <inheritdoc />
    public virtual string GenusName => "Enneacanthus";

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
