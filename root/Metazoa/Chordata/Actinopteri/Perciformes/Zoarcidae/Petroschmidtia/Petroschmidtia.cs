using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Petroschmidtia;

/// <summary>
/// Abstract class for Petroschmidtia (genus).
/// NCBI TaxId: 2056728
/// </summary>
public abstract class Petroschmidtia : Zoarcidae, IPetroschmidtia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petroschmidtia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2056728;

    /// <inheritdoc />
    public virtual string GenusName => "Petroschmidtia";

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
