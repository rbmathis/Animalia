using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Bolbometopon;

/// <summary>
/// Abstract class for Bolbometopon (genus).
/// NCBI TaxId: 188109
/// </summary>
public abstract class Bolbometopon : Labridae, IBolbometopon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bolbometopon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188109;

    /// <inheritdoc />
    public virtual string GenusName => "Bolbometopon";

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
