using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Mystus;

/// <summary>
/// Abstract class for Mystus (genus).
/// NCBI TaxId: 205131
/// </summary>
public abstract class Mystus : Bagridae, IMystus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mystus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205131;

    /// <inheritdoc />
    public virtual string GenusName => "Mystus";

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
