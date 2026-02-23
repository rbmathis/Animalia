using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Bagroides;

/// <summary>
/// Abstract class for Bagroides (genus).
/// NCBI TaxId: 2709346
/// </summary>
public abstract class Bagroides : Bagridae, IBagroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bagroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2709346;

    /// <inheritdoc />
    public virtual string GenusName => "Bagroides";

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
