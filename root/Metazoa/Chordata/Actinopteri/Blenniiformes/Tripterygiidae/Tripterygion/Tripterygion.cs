using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Tripterygion;

/// <summary>
/// Abstract class for Tripterygion (genus).
/// NCBI TaxId: 57861
/// </summary>
public abstract class Tripterygion : Tripterygiidae, ITripterygion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tripterygion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57861;

    /// <inheritdoc />
    public virtual string GenusName => "Tripterygion";

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
