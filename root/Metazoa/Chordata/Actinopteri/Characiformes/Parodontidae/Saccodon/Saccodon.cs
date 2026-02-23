using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Saccodon;

/// <summary>
/// Abstract class for Saccodon (genus).
/// NCBI TaxId: 1842731
/// </summary>
public abstract class Saccodon : Parodontidae, ISaccodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saccodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1842731;

    /// <inheritdoc />
    public virtual string GenusName => "Saccodon";

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
