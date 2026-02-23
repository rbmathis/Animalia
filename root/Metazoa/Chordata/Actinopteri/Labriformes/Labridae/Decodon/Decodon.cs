using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Decodon;

/// <summary>
/// Abstract class for Decodon (genus).
/// NCBI TaxId: 210583
/// </summary>
public abstract class Decodon : Labridae, IDecodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Decodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210583;

    /// <inheritdoc />
    public virtual string GenusName => "Decodon";

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
