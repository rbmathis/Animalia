using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Candidia;

/// <summary>
/// Abstract class for Candidia (genus).
/// NCBI TaxId: 160764
/// </summary>
public abstract class Candidia : Xenocyprididae, ICandidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Candidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160764;

    /// <inheritdoc />
    public virtual string GenusName => "Candidia";

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
