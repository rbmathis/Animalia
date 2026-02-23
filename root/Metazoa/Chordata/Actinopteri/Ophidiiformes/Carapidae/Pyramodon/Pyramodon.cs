using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Pyramodon;

/// <summary>
/// Abstract class for Pyramodon (genus).
/// NCBI TaxId: 1051624
/// </summary>
public abstract class Pyramodon : Carapidae, IPyramodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyramodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1051624;

    /// <inheritdoc />
    public virtual string GenusName => "Pyramodon";

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
