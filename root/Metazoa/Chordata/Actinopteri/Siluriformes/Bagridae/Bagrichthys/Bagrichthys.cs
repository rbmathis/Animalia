using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Bagrichthys;

/// <summary>
/// Abstract class for Bagrichthys (genus).
/// NCBI TaxId: 337740
/// </summary>
public abstract class Bagrichthys : Bagridae, IBagrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bagrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337740;

    /// <inheritdoc />
    public virtual string GenusName => "Bagrichthys";

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
