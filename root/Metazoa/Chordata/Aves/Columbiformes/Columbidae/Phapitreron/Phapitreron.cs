using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Phapitreron;

/// <summary>
/// Abstract class for Phapitreron (genus).
/// NCBI TaxId: 115681
/// </summary>
public abstract class Phapitreron : Columbidae, IPhapitreron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phapitreron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115681;

    /// <inheritdoc />
    public virtual string GenusName => "Phapitreron";

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
