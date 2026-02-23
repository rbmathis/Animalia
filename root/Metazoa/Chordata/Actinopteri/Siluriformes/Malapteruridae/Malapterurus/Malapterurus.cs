using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae.Malapterurus;

/// <summary>
/// Abstract class for Malapterurus (genus).
/// NCBI TaxId: 36715
/// </summary>
public abstract class Malapterurus : Malapteruridae, IMalapterurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malapterurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36715;

    /// <inheritdoc />
    public virtual string GenusName => "Malapterurus";

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
