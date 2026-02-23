using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Lepturacanthus;

/// <summary>
/// Abstract class for Lepturacanthus (genus).
/// NCBI TaxId: 255300
/// </summary>
public abstract class Lepturacanthus : Trichiuridae, ILepturacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepturacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255300;

    /// <inheritdoc />
    public virtual string GenusName => "Lepturacanthus";

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
