using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Bunocephalus;

/// <summary>
/// Abstract class for Bunocephalus (genus).
/// NCBI TaxId: 337533
/// </summary>
public abstract class Bunocephalus : Aspredinidae, IBunocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bunocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337533;

    /// <inheritdoc />
    public virtual string GenusName => "Bunocephalus";

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
