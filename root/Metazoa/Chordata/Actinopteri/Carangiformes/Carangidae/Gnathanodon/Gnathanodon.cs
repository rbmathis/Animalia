using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Gnathanodon;

/// <summary>
/// Abstract class for Gnathanodon (genus).
/// NCBI TaxId: 326723
/// </summary>
public abstract class Gnathanodon : Carangidae, IGnathanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathanodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326723;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathanodon";

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
