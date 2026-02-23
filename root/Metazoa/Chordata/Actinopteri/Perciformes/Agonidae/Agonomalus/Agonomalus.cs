using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Agonomalus;

/// <summary>
/// Abstract class for Agonomalus (genus).
/// NCBI TaxId: 1633496
/// </summary>
public abstract class Agonomalus : Agonidae, IAgonomalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agonomalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633496;

    /// <inheritdoc />
    public virtual string GenusName => "Agonomalus";

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
