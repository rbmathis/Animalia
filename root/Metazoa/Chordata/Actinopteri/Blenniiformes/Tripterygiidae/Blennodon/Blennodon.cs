using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Blennodon;

/// <summary>
/// Abstract class for Blennodon (genus).
/// NCBI TaxId: 2696652
/// </summary>
public abstract class Blennodon : Tripterygiidae, IBlennodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blennodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696652;

    /// <inheritdoc />
    public virtual string GenusName => "Blennodon";

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
