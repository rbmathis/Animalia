using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Prionotus;

/// <summary>
/// Abstract class for Prionotus (genus).
/// NCBI TaxId: 320587
/// </summary>
public abstract class Prionotus : Triglidae, IPrionotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320587;

    /// <inheritdoc />
    public virtual string GenusName => "Prionotus";

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
