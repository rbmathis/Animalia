using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Lyriocephalus;

/// <summary>
/// Abstract class for Lyriocephalus (genus).
/// NCBI TaxId: 118217
/// </summary>
public abstract class Lyriocephalus : Agamidae, ILyriocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyriocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118217;

    /// <inheritdoc />
    public virtual string GenusName => "Lyriocephalus";

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
