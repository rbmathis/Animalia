using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Coryphopterus;

/// <summary>
/// Abstract class for Coryphopterus (genus).
/// NCBI TaxId: 79887
/// </summary>
public abstract class Coryphopterus : Gobiidae, ICoryphopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79887;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphopterus";

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
