using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Puck;

/// <summary>
/// Abstract class for Puck (genus).
/// NCBI TaxId: 412636
/// </summary>
public abstract class Puck : Oneirodidae, IPuck
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Puck";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412636;

    /// <inheritdoc />
    public virtual string GenusName => "Puck";

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
