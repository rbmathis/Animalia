using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ichthyapus;

/// <summary>
/// Abstract class for Ichthyapus (genus).
/// NCBI TaxId: 182432
/// </summary>
public abstract class Ichthyapus : Ophichthidae, IIchthyapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182432;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyapus";

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
