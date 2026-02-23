using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Benthodesmus;

/// <summary>
/// Abstract class for Benthodesmus (genus).
/// NCBI TaxId: 473351
/// </summary>
public abstract class Benthodesmus : Trichiuridae, IBenthodesmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthodesmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473351;

    /// <inheritdoc />
    public virtual string GenusName => "Benthodesmus";

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
