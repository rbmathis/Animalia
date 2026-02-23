using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Hypentelium;

/// <summary>
/// Abstract class for Hypentelium (genus).
/// NCBI TaxId: 61315
/// </summary>
public abstract class Hypentelium : Catostomidae, IHypentelium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypentelium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61315;

    /// <inheritdoc />
    public virtual string GenusName => "Hypentelium";

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
