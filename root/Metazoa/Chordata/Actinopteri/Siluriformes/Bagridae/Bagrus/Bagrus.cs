using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Bagrus;

/// <summary>
/// Abstract class for Bagrus (genus).
/// NCBI TaxId: 390464
/// </summary>
public abstract class Bagrus : Bagridae, IBagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390464;

    /// <inheritdoc />
    public virtual string GenusName => "Bagrus";

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
