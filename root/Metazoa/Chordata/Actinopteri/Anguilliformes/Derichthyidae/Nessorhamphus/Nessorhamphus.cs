using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Derichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Derichthyidae.Nessorhamphus;

/// <summary>
/// Abstract class for Nessorhamphus (genus).
/// NCBI TaxId: 118159
/// </summary>
public abstract class Nessorhamphus : Derichthyidae, INessorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nessorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118159;

    /// <inheritdoc />
    public virtual string GenusName => "Nessorhamphus";

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
