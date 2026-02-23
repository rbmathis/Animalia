using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Zaedyus;

/// <summary>
/// Abstract class for Zaedyus (genus).
/// NCBI TaxId: 183746
/// </summary>
public abstract class Zaedyus : Chlamyphoridae, IZaedyus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zaedyus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183746;

    /// <inheritdoc />
    public virtual string GenusName => "Zaedyus";

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
