using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Radiicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Radiicephalidae.Radiicephalus;

/// <summary>
/// Abstract class for Radiicephalus (genus).
/// NCBI TaxId: 2498822
/// </summary>
public abstract class Radiicephalus : Radiicephalidae, IRadiicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Radiicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2498822;

    /// <inheritdoc />
    public virtual string GenusName => "Radiicephalus";

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
